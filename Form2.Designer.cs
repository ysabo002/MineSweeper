namespace MineSweeper
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMines = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMinesFlags = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMines
            // 
            this.btnMines.Image = global::MineSweeper.Properties.Resources.icons8_land_mine_16;
            this.btnMines.Location = new System.Drawing.Point(492, 27);
            this.btnMines.Name = "btnMines";
            this.btnMines.Size = new System.Drawing.Size(47, 35);
            this.btnMines.TabIndex = 6;
            this.btnMines.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MineSweeper.Properties.Resources.slightly_smiling_face_48px;
            this.pictureBox1.Location = new System.Drawing.Point(265, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMinesFlags
            // 
            this.lblMinesFlags.AutoSize = true;
            this.lblMinesFlags.Location = new System.Drawing.Point(554, 42);
            this.lblMinesFlags.Name = "lblMinesFlags";
            this.lblMinesFlags.Size = new System.Drawing.Size(12, 20);
            this.lblMinesFlags.TabIndex = 7;
            this.lblMinesFlags.Text = "aaa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(645, 502);
            this.Controls.Add(this.lblMinesFlags);
            this.Controls.Add(this.btnMines);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Deactivate += new System.EventHandler(this.TimerStops);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMines;
        private System.Windows.Forms.Label lblMinesFlags;
    }
}