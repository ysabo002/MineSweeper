using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if (numRows.Value * numCols.Value < 18)
                MessageBox.Show("Field is too small, try again");
            else if (numMines.Value > numRows.Value * numCols.Value / 2)
                MessageBox.Show("Too many mines, try again");
            else if (numRows.Value * numCols.Value > 5000)
                MessageBox.Show("Field is too big, try again");
            else
            {
                ((MainForm)this.Owner).customSet = true;
                ((MainForm)this.Owner).row = (int)numRows.Value;
                ((MainForm)this.Owner).col = (int)numCols.Value;
                ((MainForm)this.Owner).mines = (int)numMines.Value;
                this.Close();

            }

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
