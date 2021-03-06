using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MineSweeper
{
    public partial class Form2 : Form

    {

        
        public Form2()
        {
            InitializeComponent();
            
        }

        

        public Form2(String text, int row, int col, int size, int mines, String name) : this()
        {
            this.Text = text + "   -  " + name;
            field = new Field(row, col, mines);
            this.ClientSize = new Size(row * size , col * size + 150);

            this.Controls.Add(timerLabel);

            this.timerLabel.Text = printedTime;
           


            this.pictureBox1.Location = new Point((row * size/2), 5);

            minesFlagsCounter = mines;
            this.col = col;
            this.row = row;


            buttons = new Button[row][];
            for (int i = 0; i < row; i++)
                buttons[i] = new Button[col];
            foreach (int i in Enumerable.Range(0, row))
                foreach (int j in Enumerable.Range(0, col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size, size);
                    buttons[i][j].Location = new Point(size * i, size * j + 70);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    this.Controls.Add(buttons[i][j]);

                    
                }

            
        }

      

        private void Button_Click(object sender, MouseEventArgs e)
        {

            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
            timer.Start();
           
            

            GameClicked = true;
            this.lblMinesFlags.Text = minesFlagsCounter.ToString();
            this.lblMinesFlags.Refresh();

            Button b = (Button)sender;
            int temp = b.Name.IndexOf(",");
            int click_x = Int16.Parse(b.Name.Substring(0, temp));
            int click_y = Int16.Parse(b.Name.Substring(temp + 1));
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    if (!this.field.Started)
                        this.field.Initialize(click_x, click_y);
                    int n = this.field.CountMines(click_x, click_y);
                    if (this.field.IsMine(click_x, click_y))
                    {
                        b.BackColor = Color.Red;
                        b.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\icons8_land_mine.ico");
                        gameFinished = true;

                        this.pictureBox1.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\dizzy_face_48px.png");
                        //this.showAllMines(row, col);
                        MessageBox.Show("Game Over! You clicked on a mine!");
                        this.Close();

                        break;
                    }
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    foreach (int k in this.field.GetSafeIsland(click_x, click_y))
                    {
                        int i = k / buttons[0].Length;
                        int j = k % buttons[0].Length;
                        buttons[i][j].BackColor = Color.LightGray;
                        int m = this.field.CountMines(i, j);
                        if (m > 0)
                        {
                            buttons[i][j].Text = m + "";
                            if (m == 1)
                                buttons[i][j].BackColor = Color.LightBlue;
                            if (m == 2)
                                buttons[i][j].BackColor = Color.LightYellow;
                            if (m == 3)
                                buttons[i][j].BackColor = Color.LightPink;
                            if (m == 4)
                                buttons[i][j].BackColor = Color.LightCyan;
                            if (m == 5)
                                buttons[i][j].BackColor = Color.LightSalmon;
                        }
                        else
                            buttons[i][j].Enabled = false;
                    }
                    if (field.Win())
                    {

                        gameFinished = true;
                        this.pictureBox1.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\smiling_face_with_sunglasses_48px.png");
                        MessageBox.Show("Congratulations! you won in " + printedTime + "seconds");
                        this.Close();
                    }

                    break;
                case MouseButtons.Right:
                    // Right click
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    if (field.Flagged.Contains(click_x * buttons[0].Length + click_y))
                    {
                        
                        
                        b.BackColor = Color.White;
                        field.Flagged.Remove(click_x * buttons[0].Length + click_y);
                        minesFlagsCounter++;
                        this.lblMinesFlags.Text = minesFlagsCounter.ToString();
                        this.lblMinesFlags.Refresh();
                    }
                    else
                    {
                        
                        b.BackColor = Color.Green;
                        minesFlagsCounter--;
                        this.lblMinesFlags.Text = minesFlagsCounter.ToString();
                        lblMinesFlags.Refresh();
                        //b.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\icons8_green_flag_16.png");
                        field.Flagged.Add(click_x * buttons[0].Length + click_y);
                    }
                    break;
                case MouseButtons.Middle:
                    if (!this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    int Flagged_Count = 0;
                    


                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                        if (field.Flagged.Contains(k))
                        {
                            Flagged_Count++;
                            minesFlagsCounter --;
                            this.lblMinesFlags.Text = minesFlagsCounter.ToString();
                            this.lblMinesFlags.Refresh();
                        }
                    if (this.field.CountMines(click_x, click_y) != Flagged_Count)
                        break;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                    {
                        if (field.Flagged.Contains(k) || field.Discovered.Contains(k))
                            continue;
                        if (this.field.IsMine(k / buttons[0].Length, k % buttons[0].Length))
                        {

                            gameFinished = true;
                            b.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\icons8_land_mine.ico");
                            b.BackColor = Color.Red;
                            showAllMines(row, col);
                            MessageBox.Show("Game Over! You clicked on a mine!");
                            break;
                        }
                        foreach (int l in this.field.GetSafeIsland(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            int i = l / buttons[0].Length;
                            int j = l % buttons[0].Length;
                            buttons[i][j].BackColor = Color.LightGray;
                            int m = this.field.CountMines(i, j);
                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].BackColor = Color.LightBlue;
                            }
                            else
                                buttons[i][j].Enabled = false;
                        }
                        if (field.Win())
                        {
                            gameFinished = true;
                            this.pictureBox1.Image = Image.FromFile("C:\\Users\\ysabo\\Dropbox\\school\\Fall 2021\\COP 4226 Adv Windows Programming\\Assignments\\A2\\MineSweeper\\MineSweeper\\Resources\\Icons\\smiling_face_with_sunglasses_48px.png");
                            MessageBox.Show("Congratulations! you won in " + printedTime + "seconds");
                        }

                    }
                    break;
            }


        }
    
    
        private void Timer_Tick(object sender, EventArgs e)
        {
            ticker++;
            TimeSpan time = TimeSpan.FromSeconds(ticker);
            printedTime = time.ToString(@"hh\:mm\:ss");
            timerLabel.Text = printedTime;


         }

        private void TimerStops(object sender, EventArgs e)
        {
            timer.Enabled = false;
            TimeSpan time = TimeSpan.FromSeconds(ticker);
            printedTime = time.ToString(@"hh\:mm\:ss");
            timerLabel.Text = printedTime;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
            this.MaximizeBox = false;
           
        }

        private void confirmClosing(object sender, FormClosingEventArgs e)
        {
         
            if (GameClicked == true && gameFinished == false)
            {
                if (MessageBox.Show("Are you sure you want to close this form?", "Closing confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void showAllMines (int row, int col)
        {
           //Button[][] buttons = new Button[row][];
           // for (int a = 0; a < row; a++)
           //     buttons[a] = new Button[col];
            Button b = new Button();
            Button[,] buttons = new Button[row,col];

            foreach (Button bu in buttons)
               // foreach (int j in Enumerable.Range(0, col))
                 //   if (this.field.IsMine(i, j))
                       
                         bu.BackColor = Color.BlueViolet;

        }

      
        






        private Button[][] buttons;
        private Field field;
        private readonly System.Windows.Forms.Label timerLabel = new System.Windows.Forms.Label();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private String printedTime = "00:00:00";
        private int ticker;
        private Boolean GameClicked = false;
        private Boolean gameFinished = false;
        private int minesFlagsCounter = 0;
        private int col = 0;
        private int row = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMines_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MinesPict_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

