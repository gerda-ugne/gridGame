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
            this.EasyBtn = new System.Windows.Forms.Button();
            this.MediumBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyLbl = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.Location = new System.Drawing.Point(46, 525);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(146, 68);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = true;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // MediumBtn
            // 
            this.MediumBtn.Location = new System.Drawing.Point(268, 525);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(146, 68);
            this.MediumBtn.TabIndex = 1;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = true;
            this.MediumBtn.Click += new System.EventHandler(this.MediumBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.Location = new System.Drawing.Point(493, 525);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(146, 68);
            this.HardBtn.TabIndex = 2;
            this.HardBtn.Text = "Hard";
            this.HardBtn.UseVisualStyleBackColor = true;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(62, 53);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Highscores:";
            // 
            // DifficultyLbl
            // 
            this.DifficultyLbl.AutoSize = true;
            this.DifficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLbl.Location = new System.Drawing.Point(172, 165);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(73, 20);
            this.DifficultyLbl.TabIndex = 5;
            this.DifficultyLbl.Text = "Difficulty:";
            // 
            // ScoreBox
            // 
            this.ScoreBox.FormattingEnabled = true;
            this.ScoreBox.Location = new System.Drawing.Point(176, 188);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(341, 303);
            this.ScoreBox.TabIndex = 6;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.DifficultyLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.MediumBtn);
            this.Controls.Add(this.EasyBtn);
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
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
    }
}