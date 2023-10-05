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
        // Variables
        // Allow form moving without a border
        bool mouseDown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear the errors every 1.5 seconds
            tmrClearErrors.Start();
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            // Select all characters inside the form field once focused
            txbUsername.SelectAll();
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            // Select all characters inside the form field once focused
            txbPassword.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check whether the username/password fields are empty strings or not
            if (string.IsNullOrEmpty(txbUsername.Text) || string.IsNullOrEmpty(txbPassword.Text))
            {
                // If fields are empty, display error
                lblUsernameError.Text = "Field cannot be blank";
                lblPasswordError.Text = "Field cannot be blank";
            }
            else
            {
                // If fields are not empty, run the login function
                // Database connection string
                string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

                // Create a new database SQL connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection, declare variables (username and password)
                    connection.Open();
                    string username = txbUsername.Text;
                    string password = txbPassword.Text;
                    // Count all the identical usernames and passwords from the database
                    // If any are found, redirect the user to the specified location and log them in
                    string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    // Select query from database
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Add the user's information to the current user
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Variable to count all found database queries
                        // Return only the first result to prevent stuttering/looping
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // If any results are found, hide the current form, display the second form
                        // and hand along the logged in user's username to access it
                        if (count > 0)
                        {
                            this.Hide();
                            Form2 secondForm = new Form2(username);
                            secondForm.Show();
                        }
                        else
                        {
                            // If no results are found, give an error message
                            MessageBox.Show("Login failed. Please check your credentials.");
                        }
                    }
                }
            }    
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            // Replace every letter with a visual asterix in the password field
            txbPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check whether the user entered proper credentials in the register form
            if (txbConfirmPassword.Text == null || txbConfirmPassword.Text != txbRegisterPassword.Text)
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
            pnlLogin.Visible = false;
            tmrDisplayForm.Start();
        }

        private void tmrDisplayForm_Tick(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            tmrDisplayForm.Stop();
        }
    }
}
