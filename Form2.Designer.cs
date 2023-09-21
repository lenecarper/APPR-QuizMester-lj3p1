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
            this.pcbQuizIcon = new System.Windows.Forms.PictureBox();
            this.lblQuizQuestion = new System.Windows.Forms.Label();
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
            // lblQuizQuestion
            // 
            this.lblQuizQuestion.AutoSize = true;
            this.lblQuizQuestion.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizQuestion.Location = new System.Drawing.Point(116, 31);
            this.lblQuizQuestion.Name = "lblQuizQuestion";
            this.lblQuizQuestion.Size = new System.Drawing.Size(72, 25);
            this.lblQuizQuestion.TabIndex = 1;
            this.lblQuizQuestion.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1099, 572);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pcbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuizIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pcbQuizIcon;
        private System.Windows.Forms.Label lblQuizQuestion;
    }
}