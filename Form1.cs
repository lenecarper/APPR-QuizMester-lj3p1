﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPR_QuizMester_lj3p1
{
    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrClearErrors.Start();
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.SelectAll();
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "")
            {
                lblUsernameError.Text = "Wrong username, please try again";
            }
            else if (txbPassword.Text == "")
            {
                lblPasswordError.Text = "Wrong password, please try again";
            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbRegisterUser.Text == "")
            {
                lblRegisterUsernameError.Text = "Username cannot be blank or already exists";
            }

            if (txbRegisterPassword.Text == "")
            {
                lblRegisterPasswordError.Text = "Password cannot be blank";
            }

            if (txbConfirmPassword.Text == "" || txbConfirmPassword.Text != txbRegisterPassword.Text)
            {
                lblConfirmPasswordError.Text = "Passwords do not match";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblRegisterUsernameError.Text = "";
            lblRegisterPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbUsername.Focus();
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbRegisterUser.Focus();
        }

        private void txbRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            txbRegisterPassword.PasswordChar = '*';
        }

        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            txbRegisterPassword.PasswordChar = '*';

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
