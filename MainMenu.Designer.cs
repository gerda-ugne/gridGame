namespace Grid_Game
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartBtn = new System.Windows.Forms.Button();
            this.HighScoresBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleImg = new System.Windows.Forms.PictureBox();
            this.MagawaBtn = new System.Windows.Forms.Button();
            this.ButtonHTP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TitleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("Molot", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(244, 217);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(168, 52);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // HighScoresBtn
            // 
            this.HighScoresBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.HighScoresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighScoresBtn.Font = new System.Drawing.Font("Molot", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoresBtn.Location = new System.Drawing.Point(244, 333);
            this.HighScoresBtn.Name = "HighScoresBtn";
            this.HighScoresBtn.Size = new System.Drawing.Size(168, 52);
            this.HighScoresBtn.TabIndex = 1;
            this.HighScoresBtn.Text = "High Scores";
            this.HighScoresBtn.UseVisualStyleBackColor = false;
            this.HighScoresBtn.Click += new System.EventHandler(this.HighScoresBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Molot", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(244, 449);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(168, 52);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AllowDrop = true;
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLbl.Font = new System.Drawing.Font("Molot", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.TitleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLbl.Location = new System.Drawing.Point(83, 110);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(495, 55);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Magawa\'s Minefield\r\n";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // TitleImg
            // 
            this.TitleImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleImg.BackgroundImage")));
            this.TitleImg.InitialImage = null;
            this.TitleImg.Location = new System.Drawing.Point(0, -11);
            this.TitleImg.Name = "TitleImg";
            this.TitleImg.Size = new System.Drawing.Size(740, 824);
            this.TitleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TitleImg.TabIndex = 5;
            this.TitleImg.TabStop = false;
            this.TitleImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MagawaBtn
            // 
            this.MagawaBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.MagawaBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.MagawaBtn.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagawaBtn.Location = new System.Drawing.Point(244, 391);
            this.MagawaBtn.Name = "MagawaBtn";
            this.MagawaBtn.Size = new System.Drawing.Size(168, 52);
            this.MagawaBtn.TabIndex = 6;
            this.MagawaBtn.Text = "Who is Magawa?";
            this.MagawaBtn.UseVisualStyleBackColor = false;
            this.MagawaBtn.Click += new System.EventHandler(this.MagawaBtn_Click);
            // 
            // ButtonHTP
            // 
            this.ButtonHTP.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonHTP.Cursor = System.Windows.Forms.Cursors.Help;
            this.ButtonHTP.Font = new System.Drawing.Font("Molot", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHTP.Location = new System.Drawing.Point(244, 275);
            this.ButtonHTP.Name = "ButtonHTP";
            this.ButtonHTP.Size = new System.Drawing.Size(168, 52);
            this.ButtonHTP.TabIndex = 7;
            this.ButtonHTP.Text = "How To Play";
            this.ButtonHTP.UseVisualStyleBackColor = false;
            this.ButtonHTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Molot", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(616, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 53);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonHTP);
            this.Controls.Add(this.MagawaBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HighScoresBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TitleImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magawa\'s Minefield";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button HighScoresBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox TitleImg;
        private System.Windows.Forms.Button MagawaBtn;
        private System.Windows.Forms.Button ButtonHTP;
        private System.Windows.Forms.Button button2;
    }
}