
namespace APPR_QuizMester_lj3p1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.pnlLoginLogo = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.pnlBottom2 = new System.Windows.Forms.Panel();
            this.pcbPassword = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.pnlBottom1 = new System.Windows.Forms.Panel();
            this.pcbUsername = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(5, 5);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(1108, 50);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // pnlLoginLogo
            // 
            this.pnlLoginLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.pnlLoginLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginLogo.Location = new System.Drawing.Point(5, 55);
            this.pnlLoginLogo.Name = "pnlLoginLogo";
            this.pnlLoginLogo.Size = new System.Drawing.Size(200, 504);
            this.pnlLoginLogo.TabIndex = 1;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.panel3);
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(205, 55);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(908, 504);
            this.pnlLogin.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPasswordError);
            this.panel3.Controls.Add(this.pnlBottom2);
            this.panel3.Controls.Add(this.pcbPassword);
            this.panel3.Controls.Add(this.lblPassword);
            this.panel3.Controls.Add(this.txbPassword);
            this.panel3.Location = new System.Drawing.Point(126, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 100);
            this.panel3.TabIndex = 7;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswordError.Location = new System.Drawing.Point(257, 72);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 18);
            this.lblPasswordError.TabIndex = 6;
            // 
            // pnlBottom2
            // 
            this.pnlBottom2.BackColor = System.Drawing.Color.White;
            this.pnlBottom2.Location = new System.Drawing.Point(260, 68);
            this.pnlBottom2.Name = "pnlBottom2";
            this.pnlBottom2.Size = new System.Drawing.Size(285, 1);
            this.pnlBottom2.TabIndex = 5;
            // 
            // pcbPassword
            // 
            this.pcbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbPassword.BackgroundImage")));
            this.pcbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbPassword.Location = new System.Drawing.Point(8, 17);
            this.pcbPassword.Name = "pcbPassword";
            this.pcbPassword.Size = new System.Drawing.Size(100, 69);
            this.pcbPassword.TabIndex = 4;
            this.pcbPassword.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(114, 33);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 29);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.White;
            this.txbPassword.Location = new System.Drawing.Point(260, 30);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(285, 29);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsernameError);
            this.panel1.Controls.Add(this.pnlBottom1);
            this.panel1.Controls.Add(this.pcbUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txbUsername);
            this.panel1.Location = new System.Drawing.Point(126, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsernameError.Location = new System.Drawing.Point(257, 70);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(0, 18);
            this.lblUsernameError.TabIndex = 6;
            // 
            // pnlBottom1
            // 
            this.pnlBottom1.BackColor = System.Drawing.Color.White;
            this.pnlBottom1.Location = new System.Drawing.Point(260, 68);
            this.pnlBottom1.Name = "pnlBottom1";
            this.pnlBottom1.Size = new System.Drawing.Size(285, 1);
            this.pnlBottom1.TabIndex = 5;
            // 
            // pcbUsername
            // 
            this.pcbUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbUsername.BackgroundImage")));
            this.pcbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbUsername.Location = new System.Drawing.Point(8, 17);
            this.pcbUsername.Name = "pcbUsername";
            this.pcbUsername.Size = new System.Drawing.Size(100, 71);
            this.pcbUsername.TabIndex = 4;
            this.pcbUsername.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(115, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(130, 29);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.White;
            this.txbUsername.Location = new System.Drawing.Point(260, 33);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(285, 29);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(418, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 29);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(317, 388);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 56);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1118, 564);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLoginLogo);
            this.Controls.Add(this.pnlTopHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Panel pnlLoginLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbUsername;
        private System.Windows.Forms.Panel pnlBottom1;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Panel pnlBottom2;
        private System.Windows.Forms.PictureBox pcbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

