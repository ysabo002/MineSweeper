using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{   
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int row = 0, col = 0, mines = 0;   //row*col >=18, mines <= row*col/2
        public Boolean customSet = false;

      

        private void Play(object sender, EventArgs e)
        {
            
            String text = "";
            Form2 f = null;
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;


                text = "Easy";
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
            }
            else if (expert.Checked)
            {
                row = 30;
                col = 16;
                mines = 99;
                text = "Expert";
            }
            else if (custom.Checked)
            {

                Form customForm = new Form3();
                customForm.Owner = this;
                while (true)
                {
                    if (customForm.ShowDialog() == DialogResult.Cancel)
                        break;
                    if (customSet)
                    {
                        text = "Custom: " + row + " by " + col + " & " + mines + " mines.";
                        break;
                    }
                }

            }
            else
                return;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            
            f = new Form2(text, row, col, size ,mines, textBoxPlayerName.Text);
            f.Owner = this;

            f.FormClosed += new FormClosedEventHandler(Form2Closed);
                   
            Utilities.openGames++;
            textBoxOpenGam.Text = Utilities.openGames.ToString();


            f.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnCustomChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCloseAllGamesClick(object sender, EventArgs e)
        {

            if (this.OwnedForms.Count() < 1)

                MessageBox.Show("There is no open games!");

            foreach (Form f in this.OwnedForms)
            {
                f.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelColumn(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            medium.Checked = true;
            textBoxOpenGam.Text = Utilities.openGames.ToString();
           
           
        }

        private void labelRow(object sender, EventArgs e)
        {

        }

        private void textBoxRowTextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColumnTextChanged(object sender, EventArgs e)
        {
            textBoxOpenGam.Text = Utilities.openGames.ToString();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxOpenGam.Text = Utilities.openGames.ToString();
        }

       

        private void textBoxOpenGam_TextChanged(object sender, EventArgs e)
        {

        }
        void Form2Closed(object sender, FormClosedEventArgs e)
        {
            Utilities.openGames--;
            textBoxOpenGam.Text = Utilities.openGames.ToString();

        }

       

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {

            custom.Checked = true;
        }

       
        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            easy.Checked = true;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medium.Checked = true;
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expert.Checked = true;
        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {
            custom.Checked = true;
        }

        private void expert_CheckedChanged(object sender, EventArgs e)
        {
            expert.Checked = true;
        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            medium.Checked = true;
        }

        private void easy_CheckedChanged(object sender, EventArgs e)
        {
            easy.Checked = true;
        }

     

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custom.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
