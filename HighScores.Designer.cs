namespace Grid_Game
{
    partial class HighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScores));
            this.EasyBtn = new System.Windows.Forms.Button();
            this.MediumBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyLbl = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.EasyBtn.Font = new System.Drawing.Font("Molot", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyBtn.Location = new System.Drawing.Point(438, 346);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(146, 68);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = false;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // MediumBtn
            // 
            this.MediumBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.MediumBtn.Font = new System.Drawing.Font("Molot", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumBtn.Location = new System.Drawing.Point(438, 272);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(146, 68);
            this.MediumBtn.TabIndex = 1;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = false;
            this.MediumBtn.Click += new System.EventHandler(this.MediumBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.HardBtn.Font = new System.Drawing.Font("Molot", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardBtn.Location = new System.Drawing.Point(438, 198);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(146, 68);
            this.HardBtn.TabIndex = 2;
            this.HardBtn.Text = "Hard";
            this.HardBtn.UseVisualStyleBackColor = false;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.BackBtn.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(62, 53);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Molot", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(85, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Highscores:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DifficultyLbl
            // 
            this.DifficultyLbl.AutoSize = true;
            this.DifficultyLbl.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.DifficultyLbl.Location = new System.Drawing.Point(12, 177);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(91, 18);
            this.DifficultyLbl.TabIndex = 5;
            this.DifficultyLbl.Text = "Difficulty:";
            this.DifficultyLbl.Click += new System.EventHandler(this.DifficultyLbl_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.BackColor = System.Drawing.Color.BurlyWood;
            this.ScoreBox.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.FormattingEnabled = true;
            this.ScoreBox.ItemHeight = 18;
            this.ScoreBox.Location = new System.Drawing.Point(12, 198);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(341, 292);
            this.ScoreBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 750);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.DifficultyLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.MediumBtn);
            this.Controls.Add(this.EasyBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button MediumBtn;
        private System.Windows.Forms.Button HardBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DifficultyLbl;
        private System.Windows.Forms.ListBox ScoreBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}