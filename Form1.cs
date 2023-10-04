using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        // string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";
        Form2 secondForm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrClearErrors.Start();
            secondForm.Hide();
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
            // Placeholder to check if the credentials aren't empty
            if (txbUsername.Text == "")
            {
                lblUsernameError.Text = "Wrong username, please try again";
            }
            else if (txbPassword.Text == "")
            {
                lblPasswordError.Text = "Wrong password, please try again";
            }


            if (txbUsername.Text != "" && txbPassword.Text != "")
            {
                string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string username = txbUsername.Text;
                    string password = txbPassword.Text;
                    string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            this.Hide();
                            secondForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your credentials.");
                        }
                    }
                }
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

            if (string.IsNullOrEmpty(txbRegisterUser.Text) || string.IsNullOrEmpty(txbRegisterPassword.Text))
            {
                lblRegisterUsernameError.Text = "Username cannot be blank or already exists";
            }
            else
            {
                string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string username = txbRegisterUser.Text;
                    string password = txbRegisterPassword.Text;
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully registered, please log in.");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
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

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tmrDisplayForm.Start();
            pnlLogin.Visible = false;
        }

        private void tmrDisplayForm_Tick(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }
    }
}
