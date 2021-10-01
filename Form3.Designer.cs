
using System.Windows.Forms;

namespace MineSweeper
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        public DialogResult ShowDialog(string text, string caption)
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.numCols = new System.Windows.Forms.NumericUpDown();
            this.numMines = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMines)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(361, 373);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 65);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Confirm";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.ConfirmClick);
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(163, 240);
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(59, 26);
            this.numRows.TabIndex = 1;
            // 
            // numCols
            // 
            this.numCols.Location = new System.Drawing.Point(283, 240);
            this.numCols.Name = "numCols";
            this.numCols.Size = new System.Drawing.Size(56, 26);
            this.numCols.TabIndex = 2;
            // 
            // numMines
            // 
            this.numMines.Location = new System.Drawing.Point(398, 240);
            this.numMines.Name = "numMines";
            this.numMines.Size = new System.Drawing.Size(60, 26);
            this.numMines.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(159, 204);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(49, 20);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Rows";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(279, 204);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(71, 20);
            this.lblCols.TabIndex = 5;
            this.lblCols.Text = "Columns";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.Location = new System.Drawing.Point(400, 204);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(51, 20);
            this.lblMines.TabIndex = 6;
            this.lblMines.Text = "Mines";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Location = new System.Drawing.Point(59, 124);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(549, 20);
            this.Heading.TabIndex = 7;
            this.Heading.Text = "Please enter the number of Rows, Columns and Mines for your custom game";
            this.Heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(124, 373);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(155, 65);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(632, 560);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.lblMines);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.numMines);
            this.Controls.Add(this.numCols);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.btnOK);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private NumericUpDown numRows;
        private NumericUpDown numCols;
        private NumericUpDown numMines;
        private Label lblRows;
        private Label lblCols;
        private Label lblMines;
        private Label Heading;
        private Button cancel;
    }
}
