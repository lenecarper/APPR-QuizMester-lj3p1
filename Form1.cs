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

            // Check whether the string is empty or null, if true, display an error
            if (string.IsNullOrEmpty(txbRegisterUser.Text) || string.IsNullOrEmpty(txbRegisterPassword.Text))
            {
                lblRegisterUsernameError.Text = "Username cannot be blank or already exists";
            }
            else
            {
                // If the string is not null, add a database connection string
                string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

                // Add a new SQL database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection, get the variables from username and password
                    connection.Open();
                    string username = txbRegisterUser.Text;
                    string password = txbRegisterPassword.Text;
                    // Insert the user into the database if the credentials are valid
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                    // Add the username and password into the database with the insertQuery and connection
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Get the username and password previously declared
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Check how many rows are affected by the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // If any rows are affected, display a message saying the user can log in
                        // otherwise say registration failed and to try again
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
            // Clear all error message labels
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblRegisterUsernameError.Text = "";
            lblRegisterPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Highlight the login username textbox when the login link is clicked
            txbUsername.Focus();
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Highlight the register username textbox when the login link is clicked 
            txbRegisterUser.Focus();
        }

        private void txbRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            // Visually display an asterix as the password field value
            txbRegisterPassword.PasswordChar = '*';
        }

        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Visually display an asterix as the password field value
            txbRegisterPassword.PasswordChar = '*';

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application on exit button click
            Application.Exit();
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            // Get the current mouse location when the mouse is held down
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            // Check whether the mouse is held down or not
            if (mouseDown == true)
            {
                // Get current mouse position and save it in a Point
                Point currentScreenPos = PointToScreen(e.Location);
                // Save the location and do some math to make it function
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void MouseUp_Event(object sender, MouseEventArgs e)
        {
            // Mouse down is set to false when the user lets go
            mouseDown = false;
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Display the forgot password field
            pnlLogin.Visible = false;
            tmrDisplayForm.Start();
        }

        private void tmrDisplayForm_Tick(object sender, EventArgs e)
        {
            // Re-enable the login form, stop the display timer
            pnlLogin.Visible = true;
            tmrDisplayForm.Stop();
        }
    }
}
