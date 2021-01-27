namespace Grid_Game
{
    partial class Difficulty
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
            this.MedBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EnterNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateNameBtn = new System.Windows.Forms.Button();
            this.DifficultyLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.Location = new System.Drawing.Point(267, 289);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(159, 62);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "Easy";
            this.EasyBtn.UseVisualStyleBackColor = true;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // MedBtn
            // 
            this.MedBtn.Location = new System.Drawing.Point(267, 375);
            this.MedBtn.Name = "MedBtn";
            this.MedBtn.Size = new System.Drawing.Size(159, 61);
            this.MedBtn.TabIndex = 1;
            this.MedBtn.Text = "Medium";
            this.MedBtn.UseVisualStyleBackColor = true;
            this.MedBtn.Click += new System.EventHandler(this.MedBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.Location = new System.Drawing.Point(267, 463);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(159, 61);
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
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(101, 593);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(488, 96);
            this.StartBtn.TabIndex = 4;
            this.StartBtn.Text = "Start Game";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(363, 130);
            this.NameTextBox.MaxLength = 3;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(78, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // EnterNameLbl
            // 
            this.EnterNameLbl.AutoSize = true;
            this.EnterNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterNameLbl.Location = new System.Drawing.Point(251, 131);
            this.EnterNameLbl.Name = "EnterNameLbl";
            this.EnterNameLbl.Size = new System.Drawing.Size(106, 16);
            this.EnterNameLbl.TabIndex = 6;
            this.EnterNameLbl.Text = "Enter Nickname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Difficulty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // UpdateNameBtn
            // 
            this.UpdateNameBtn.Location = new System.Drawing.Point(301, 178);
            this.UpdateNameBtn.Name = "UpdateNameBtn";
            this.UpdateNameBtn.Size = new System.Drawing.Size(93, 23);
            this.UpdateNameBtn.TabIndex = 9;
            this.UpdateNameBtn.Text = "Change Name";
            this.UpdateNameBtn.UseVisualStyleBackColor = true;
            this.UpdateNameBtn.Click += new System.EventHandler(this.UpdateNameBtn_Click);
            // 
            // DifficultyLbl
            // 
            this.DifficultyLbl.AutoSize = true;
            this.DifficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLbl.Location = new System.Drawing.Point(96, 565);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(100, 25);
            this.DifficultyLbl.TabIndex = 10;
            this.DifficultyLbl.Text = "Difficulty:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(455, 565);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(74, 25);
            this.NameLbl.TabIndex = 11;
            this.NameLbl.Text = "Name:";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DifficultyLbl);
            this.Controls.Add(this.UpdateNameBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterNameLbl);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.MedBtn);
            this.Controls.Add(this.EasyBtn);
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button MedBtn;
        private System.Windows.Forms.Button HardBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label EnterNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateNameBtn;
        private System.Windows.Forms.Label DifficultyLbl;
        private System.Windows.Forms.Label NameLbl;
    }
}