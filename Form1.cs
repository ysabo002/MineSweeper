﻿using System;
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
            f.Owner = this;

            f.FormClosed += new FormClosedEventHandler(Form2Closed);
                   
            GameCounter.openGames++;
            textBoxOpenGam.Text = GameCounter.openGames.ToString();


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
            textBoxOpenGam.Text = GameCounter.openGames.ToString();
           
        }

        private void labelRow(object sender, EventArgs e)
        {

        }

        private void textBoxRowTextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColumnTextChanged(object sender, EventArgs e)
        {
            textBoxOpenGam.Text = GameCounter.openGames.ToString();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxOpenGam.Text = GameCounter.openGames.ToString();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void textBoxOpenGam_TextChanged(object sender, EventArgs e)
        {

        }
        void Form2Closed(object sender, FormClosedEventArgs e)
        {
            GameCounter.openGames--;
            textBoxOpenGam.Text = GameCounter.openGames.ToString();

        }

       
    }
}
