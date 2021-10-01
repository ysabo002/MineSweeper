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
            this.btnPlay = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.expert = new System.Windows.Forms.RadioButton();
            this.textBoxOpenGam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custom = new System.Windows.Forms.RadioButton();
            this.btnCloseAllGames = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(187, 352);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(164, 85);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.Play);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.BackColor = System.Drawing.Color.Transparent;
            this.easy.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.easy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easy.Location = new System.Drawing.Point(65, 148);
            this.easy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(92, 36);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.BackColor = System.Drawing.Color.Transparent;
            this.medium.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.medium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medium.Location = new System.Drawing.Point(214, 148);
            this.medium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(137, 36);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // expert
            // 
            this.expert.AutoSize = true;
            this.expert.BackColor = System.Drawing.Color.Transparent;
            this.expert.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.expert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expert.Location = new System.Drawing.Point(417, 148);
            this.expert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(116, 36);
            this.expert.TabIndex = 3;
            this.expert.Text = "Expert";
            this.expert.UseVisualStyleBackColor = false;
            this.expert.Click += new System.EventHandler(this.expert_CheckedChanged);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(165, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Open Games";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.BackColor = System.Drawing.Color.Transparent;
            this.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.custom.Location = new System.Drawing.Point(562, 148);
            this.custom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(128, 36);
            this.custom.TabIndex = 7;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = false;
            this.custom.Click += new System.EventHandler(this.custom_CheckedChanged);
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
            this.textBoxPlayerName.Size = new System.Drawing.Size(144, 26);
            this.textBoxPlayerName.TabIndex = 9;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBoxPlayerName_TextChanged);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerName.Location = new System.Drawing.Point(182, 82);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(163, 32);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playNewGameToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // playNewGameToolStripMenuItem
            // 
            this.playNewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem1,
            this.mediumToolStripMenuItem1,
            this.expertToolStripMenuItem1,
            this.customToolStripMenuItem1});
            this.playNewGameToolStripMenuItem.Name = "playNewGameToolStripMenuItem";
            this.playNewGameToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.playNewGameToolStripMenuItem.Text = "Play New Game";
            // 
            // easyToolStripMenuItem1
            // 
            this.easyToolStripMenuItem1.Name = "easyToolStripMenuItem1";
            this.easyToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.easyToolStripMenuItem1.Text = "Easy";
            this.easyToolStripMenuItem1.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem1
            // 
            this.mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            this.mediumToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.mediumToolStripMenuItem1.Text = "Medium";
            this.mediumToolStripMenuItem1.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem1
            // 
            this.expertToolStripMenuItem1.Name = "expertToolStripMenuItem1";
            this.expertToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.expertToolStripMenuItem1.Text = "Expert";
            this.expertToolStripMenuItem1.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.customToolStripMenuItem1.Text = "Custom";
            this.customToolStripMenuItem1.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.closeAllToolStripMenuItem.Text = "Close all games";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.btnCloseAllGamesClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MineSweeper.Properties.Resources.brian_patrick_tagalog__8hGFBxWD0A_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 568);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.btnCloseAllGames);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOpenGam);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton expert;
        private System.Windows.Forms.TextBox textBoxOpenGam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.Button btnCloseAllGames;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
    }
}

