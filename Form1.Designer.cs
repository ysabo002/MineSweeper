namespace MineSweeper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.expert = new System.Windows.Forms.RadioButton();
            this.textBoxOpenGam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.btnCloseAllGames = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtBoxCustRows = new System.Windows.Forms.TextBox();
            this.txtBoxCustCols = new System.Windows.Forms.TextBox();
            this.lblCustRows = new System.Windows.Forms.Label();
            this.lblCustCol = new System.Windows.Forms.Label();
            this.playNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblCustMines = new System.Windows.Forms.Label();
            this.txtBoxCustMines = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(125, 148);
            this.easy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(69, 24);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(270, 148);
            this.medium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(90, 24);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.radioButtonMediumChecked);
            // 
            // expert
            // 
            this.expert.AutoSize = true;
            this.expert.Checked = true;
            this.expert.Location = new System.Drawing.Point(433, 148);
            this.expert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(80, 24);
            this.expert.TabIndex = 3;
            this.expert.TabStop = true;
            this.expert.Text = "Expert";
            this.expert.UseVisualStyleBackColor = true;
            this.expert.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBoxOpenGam
            // 
            this.textBoxOpenGam.Location = new System.Drawing.Point(485, 485);
            this.textBoxOpenGam.Name = "textBoxOpenGam";
            this.textBoxOpenGam.Size = new System.Drawing.Size(48, 26);
            this.textBoxOpenGam.TabIndex = 4;
            this.textBoxOpenGam.Text = "0";
            this.textBoxOpenGam.TextChanged += new System.EventHandler(this.textBoxOpenGam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Open Games";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(606, 148);
            this.radioCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(89, 24);
            this.radioCustom.TabIndex = 7;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // btnCloseAllGames
            // 
            this.btnCloseAllGames.Location = new System.Drawing.Point(451, 352);
            this.btnCloseAllGames.Name = "btnCloseAllGames";
            this.btnCloseAllGames.Size = new System.Drawing.Size(187, 85);
            this.btnCloseAllGames.TabIndex = 8;
            this.btnCloseAllGames.Text = "Close all games";
            this.btnCloseAllGames.UseVisualStyleBackColor = true;
            this.btnCloseAllGames.Click += new System.EventHandler(this.btnCloseAllGamesClick);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(354, 85);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(163, 26);
            this.textBoxPlayerName.TabIndex = 9;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBoxPlayerName_TextChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(230, 91);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(98, 20);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxCustRows
            // 
            this.txtBoxCustRows.Location = new System.Drawing.Point(187, 267);
            this.txtBoxCustRows.Name = "txtBoxCustRows";
            this.txtBoxCustRows.Size = new System.Drawing.Size(61, 26);
            this.txtBoxCustRows.TabIndex = 14;
            this.txtBoxCustRows.Visible = false;
            this.txtBoxCustRows.TextChanged += new System.EventHandler(this.textBoxRowTextChanged);
            // 
            // txtBoxCustCols
            // 
            this.txtBoxCustCols.Location = new System.Drawing.Point(354, 264);
            this.txtBoxCustCols.Name = "txtBoxCustCols";
            this.txtBoxCustCols.Size = new System.Drawing.Size(61, 26);
            this.txtBoxCustCols.TabIndex = 15;
            this.txtBoxCustCols.Visible = false;
            this.txtBoxCustCols.TextChanged += new System.EventHandler(this.textBoxColumnTextChanged);
            // 
            // lblCustRows
            // 
            this.lblCustRows.AutoSize = true;
            this.lblCustRows.Location = new System.Drawing.Point(121, 270);
            this.lblCustRows.Name = "lblCustRows";
            this.lblCustRows.Size = new System.Drawing.Size(42, 20);
            this.lblCustRows.TabIndex = 16;
            this.lblCustRows.Text = "rows";
            this.lblCustRows.Visible = false;
            this.lblCustRows.Click += new System.EventHandler(this.labelRow);
            // 
            // lblCustCol
            // 
            this.lblCustCol.AutoSize = true;
            this.lblCustCol.Location = new System.Drawing.Point(266, 273);
            this.lblCustCol.Name = "lblCustCol";
            this.lblCustCol.Size = new System.Drawing.Size(68, 20);
            this.lblCustCol.TabIndex = 17;
            this.lblCustCol.Text = "columns";
            this.lblCustCol.Visible = false;
            this.lblCustCol.Click += new System.EventHandler(this.labelColumn);
            // 
            // playNewGameToolStripMenuItem
            // 
            this.playNewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.customToolStripMenuItem});
            this.playNewGameToolStripMenuItem.Name = "playNewGameToolStripMenuItem";
            this.playNewGameToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.playNewGameToolStripMenuItem.Text = "Play New Game";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.hardToolStripMenuItem.Text = "Hard";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playNewGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblCustMines
            // 
            this.lblCustMines.AutoSize = true;
            this.lblCustMines.Location = new System.Drawing.Point(447, 270);
            this.lblCustMines.Name = "lblCustMines";
            this.lblCustMines.Size = new System.Drawing.Size(51, 20);
            this.lblCustMines.TabIndex = 18;
            this.lblCustMines.Text = "mines";
            this.lblCustMines.Visible = false;
            // 
            // txtBoxCustMines
            // 
            this.txtBoxCustMines.Location = new System.Drawing.Point(519, 264);
            this.txtBoxCustMines.Name = "txtBoxCustMines";
            this.txtBoxCustMines.Size = new System.Drawing.Size(100, 26);
            this.txtBoxCustMines.TabIndex = 19;
            this.txtBoxCustMines.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 568);
            this.Controls.Add(this.txtBoxCustMines);
            this.Controls.Add(this.lblCustMines);
            this.Controls.Add(this.lblCustCol);
            this.Controls.Add(this.lblCustRows);
            this.Controls.Add(this.txtBoxCustCols);
            this.Controls.Add(this.txtBoxCustRows);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.btnCloseAllGames);
            this.Controls.Add(this.radioCustom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOpenGam);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton expert;
        private System.Windows.Forms.TextBox textBoxOpenGam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.Button btnCloseAllGames;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtBoxCustRows;
        private System.Windows.Forms.TextBox txtBoxCustCols;
        private System.Windows.Forms.Label lblCustRows;
        private System.Windows.Forms.Label lblCustCol;
        private System.Windows.Forms.ToolStripMenuItem playNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtBoxCustMines;
        private System.Windows.Forms.Label lblCustMines;
       
    }
}

