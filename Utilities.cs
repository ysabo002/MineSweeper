using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public static class Utilities
    {
        static public int openGames = 0;



            //Dialog for custom game
            public static DialogResult ShowDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 400;
                prompt.Height = 300;
                prompt.Text = caption;
                Label heading = new Label() { Left = 40, Top = 50, Text = text, Width = 500 };
                Label lblRows = new Label() { Left = 50, Top = 100, Text = "Rows" };
                Label lblColumns = new Label() { Left = 150, Top = 100, Text = "Columns" };
                Label lblMines = new Label() { Left = 250, Top = 100, Text = "Mines" };
                NumericUpDown inputBoxRows = new NumericUpDown() { Left = 50, Top = 120, Width = 50 };
                NumericUpDown inputBoxCol = new NumericUpDown() { Left = 150, Top = 120, Width = 50 };
                NumericUpDown inputBoxMines = new NumericUpDown() { Left = 250, Top = 120, Width = 50 };
                Button confirmation = new Button() { Text = "Confirm", Left = 150, Width = 100, Top = 200 };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                //lblRows.Text = "Rows";
                //lblColumns.Text = "Cols";
                //lblMines.Text = "Mines";
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(lblRows);
                prompt.Controls.Add(lblColumns);
                prompt.Controls.Add(lblMines);
                prompt.Controls.Add(heading);
                prompt.Controls.Add(inputBoxRows);
                prompt.Controls.Add(inputBoxCol);
                prompt.Controls.Add(inputBoxMines);
                
            //prompt.ShowDialog();
                DialogResult dialogResult = prompt.ShowDialog();
                return dialogResult;
            }


        private static void ConfirmationClick(Object sender, EventArgs e) { 
                
                
            }
        }

    }



