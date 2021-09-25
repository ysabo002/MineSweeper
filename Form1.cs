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

        private int openGames = 0;
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMediumChecked(object sender, EventArgs e)
        {

        }

        private void Play(object sender, EventArgs e)
        {
            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
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
            else
                return;
            int size = Math.Min(30, 1000 / Math.Max(row, col));
            
            f = new Form2(text, row, col, size ,mines);
            openGames++;
            textBoxOpenGam.Text = openGames.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            openGames = 0;

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
           
        }

        private void labelRow(object sender, EventArgs e)
        {

        }

        private void textBoxRowTextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColumnTextChanged(object sender, EventArgs e)
        {

        }

        private void timerTick(object sender, EventArgs e)
        {

        }

       

        private void textBoxOpenGames(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
