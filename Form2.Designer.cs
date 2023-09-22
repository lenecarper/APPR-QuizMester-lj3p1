namespace APPR_QuizMester_lj3p1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblQuizQuestion = new System.Windows.Forms.Label();
            this.pcbQuizIcon = new System.Windows.Forms.PictureBox();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblCurrentScoreHolder = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuizIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbLogo.BackgroundImage")));
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(243, 230);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBackground.Controls.Add(this.lblQuizQuestion);
            this.pnlBackground.Controls.Add(this.pcbQuizIcon);
            this.pnlBackground.Location = new System.Drawing.Point(370, 102);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(597, 140);
            this.pnlBackground.TabIndex = 1;
            // 
            // lblQuizQuestion
            // 
            this.lblQuizQuestion.AutoSize = true;
            this.lblQuizQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizQuestion.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuizQuestion.Location = new System.Drawing.Point(116, 31);
            this.lblQuizQuestion.Name = "lblQuizQuestion";
            this.lblQuizQuestion.Size = new System.Drawing.Size(150, 25);
            this.lblQuizQuestion.TabIndex = 1;
            this.lblQuizQuestion.Text = "Filler question";
            // 
            // pcbQuizIcon
            // 
            this.pcbQuizIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbQuizIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbQuizIcon.BackgroundImage")));
            this.pcbQuizIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbQuizIcon.Location = new System.Drawing.Point(0, 0);
            this.pcbQuizIcon.Name = "pcbQuizIcon";
            this.pcbQuizIcon.Size = new System.Drawing.Size(110, 140);
            this.pcbQuizIcon.TabIndex = 0;
            this.pcbQuizIcon.TabStop = false;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnswer1.FlatAppearance.BorderSize = 2;
            this.btnAnswer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnswer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(370, 259);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(282, 74);
            this.btnAnswer1.TabIndex = 9;
            this.btnAnswer1.Text = "Filler answer 1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnswer2.FlatAppearance.BorderSize = 2;
            this.btnAnswer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnswer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(685, 259);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(282, 74);
            this.btnAnswer2.TabIndex = 10;
            this.btnAnswer2.Text = "Filler answer 2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnswer3.FlatAppearance.BorderSize = 2;
            this.btnAnswer3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnswer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.Location = new System.Drawing.Point(370, 355);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(282, 74);
            this.btnAnswer3.TabIndex = 11;
            this.btnAnswer3.Text = "Filler answer 3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAnswer4.FlatAppearance.BorderSize = 2;
            this.btnAnswer4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAnswer4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.Location = new System.Drawing.Point(685, 355);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(282, 74);
            this.btnAnswer4.TabIndex = 12;
            this.btnAnswer4.Text = "Filler answer 4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // lblCurrentScoreHolder
            // 
            this.lblCurrentScoreHolder.AutoSize = true;
            this.lblCurrentScoreHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCurrentScoreHolder.Location = new System.Drawing.Point(12, 259);
            this.lblCurrentScoreHolder.Name = "lblCurrentScoreHolder";
            this.lblCurrentScoreHolder.Size = new System.Drawing.Size(172, 29);
            this.lblCurrentScoreHolder.TabIndex = 13;
            this.lblCurrentScoreHolder.Text = "Current score:";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.White;
            this.lblCurrentScore.Location = new System.Drawing.Point(190, 259);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(27, 29);
            this.lblCurrentScore.TabIndex = 14;
            this.lblCurrentScore.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1099, 572);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblCurrentScoreHolder);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pcbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuizIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pcbQuizIcon;
        private System.Windows.Forms.Label lblQuizQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblCurrentScoreHolder;
        private System.Windows.Forms.Label lblCurrentScore;
    }
}