using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace APPR_QuizMester_lj3p1
{
    public partial class Form3 : Form
    {
        // Declare variables
        // Allow form moving without a border
        bool mouseDown;
        private Point offset;
        // Current score, time left, correct/wrong answer values are all saved in an int
        int currentScore = 0;
        int timeLeft = 0;
        int correctAnswers = 0;
        int wrongAnswers = 0;
        int skipsLeft = 1;
        int assistsLeft = 1;
        int specialQuestionsLeft = 1;
        // Get the questions from a class (Question.cs) and the database
        private List<Question> questions = new List<Question>();
        private List<Question> assistQuestions = new List<Question>();
        // The question index is initiated at 0
        private int currentQuestionIndex = 0;
        bool special = false;
        // Declare and access the username variable passed along by Form1
        private string _username;
        private SqlConnection connection = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True");
        public Form3(string username)
        {
            // Access the username and initialize the project
            InitializeComponent();
            LoadQuestionsFromDatabase();
            LoadAssistQuestion();
            DisplayQuestion();
            LoadTopScores();
            _username = username;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Add a maximum size to the quiz question text, clear all selections
            // Remove the score indicator and set it to 0, update the time left
            lblQuizQuestion.MaximumSize = new Size(250, 0);
            lblQuizQuestion.AutoSize = true;
            lblCurrentScore.Text = currentScore.ToString();
            ClearSelection();
            lblScoreIndicator.Text = "";
            lblSkipIndicator.Text = "";
            lblAssistIndicator.Text = "";
        }

        private void LoadQuestionsFromDatabase()
        {
            // Database connection string
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

            // Add a new SQL database connection using the connectionString
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();
                // Add a query to select the questions, wrong answers and correct answer from the database
                // Order by NEWID() which sorts the question index randomly (built-in function)
                string query = "SELECT QuestionText, WrongAnswer1, WrongAnswer2, WrongAnswer3, CorrectAnswer FROM Questions ORDER BY NEWID()";
                // Declare a new SQLCommand using the query and connectionString
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Declare a new SQL data reader to fetch data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // While the reader is active
                        while (reader.Read())
                        {
                            // Fetch all data from the row the query was executed on
                            string questionText = reader.GetString(0);
                            string wrongAnswer1 = reader.GetString(1);
                            string wrongAnswer2 = reader.GetString(2);
                            string wrongAnswer3 = reader.GetString(3);
                            string correctAnswer = reader.GetString(4);

                            // Save the data into a List item
                            List<string> options = new List<string>
                            {
                                wrongAnswer1, wrongAnswer2, wrongAnswer3, correctAnswer
                            };

                            // Shuffle the options randomly
                            Random rng = new Random();
                            int optionCount = options.Count;
                            // While there is more than 1 option, shuffle the questions randomly
                            while (optionCount > 1)
                            {
                                // Decrement the options amount
                                optionCount--;
                                // Declare a next option by returning a non-negative int
                                // and increment 1 to the total amount
                                int optionNext = rng.Next(optionCount + 1);
                                // Save the value of the next option
                                string value = options[optionNext];
                                options[optionNext] = options[optionNext];
                                // Save the options into the value variable
                                options[optionNext] = value;
                            }
                            // Save the question as an object, add the previous data into the object
                            Question question = new Question(questionText, options, correctAnswer);
                            questions.Add(question);
                        }
                    }
                }
            }
        }

        private void DisplayQuestion()
        {
            // Check if there are any questions left
            if (currentQuestionIndex < questions.Count)
            {
                // Get the previously added data from the questions object at the selected question index
                Question question = questions[currentQuestionIndex];
                // Add the data to the form elements
                lblQuizQuestion.Text = question.Text;
                rbOption1.Text = question.Options[0];
                rbOption2.Text = question.Options[1];
                rbOption3.Text = question.Options[2];
                rbOption4.Text = question.Options[3];
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed
                MessageBox.Show("Quiz completed!");
            }

            // Check if there are any questions left
            if (currentQuestionIndex < questions.Count)
            {
                // If there are special questions left, check if a special question should be displayed
                if (specialQuestionsLeft > 0 && new Random().Next(0, 100) < 25)
                {
                    // Display a special question at a random index between 1 and 20
                    special = true;

                    // Play a sound for the special question from a file path
                    string soundFilePath = "C:\\xampp\\htdocs\\CSharp\\APPR-QuizMester-lj3p1\\APPR-QuizMester-lj3p1\\Resources\\special_sound.wav";
                    if (File.Exists(soundFilePath))
                    {
                        using (var player = new SoundPlayer(soundFilePath))
                        {
                            player.Play();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sound file not found!");
                    }

                    currentQuestionIndex = new Random().Next(1, 21);
                    specialQuestionsLeft--;

                    // Get the special question data from the questions object at the selected question index
                    Question specialQuestion = questions[currentQuestionIndex];
                    // Add the data to the form elements
                    lblQuizQuestion.Text = specialQuestion.Text;
                    rbOption1.Text = specialQuestion.Options[0];
                    rbOption2.Text = specialQuestion.Options[1];
                    rbOption3.Text = specialQuestion.Options[2];
                    rbOption4.Text = specialQuestion.Options[3];
                    MessageBox.Show("Special Question");
                }
                else
                {
                    // Get the data from the questions object at the current question index
                    Question question = questions[currentQuestionIndex];
                    // Add the data to the form elements
                    lblQuizQuestion.Text = question.Text;
                    rbOption1.Text = question.Options[0];
                    rbOption2.Text = question.Options[1];
                    rbOption3.Text = question.Options[2];
                    rbOption4.Text = question.Options[3];
                }
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed
                MessageBox.Show("Quiz completed!");
            }
        }

        private void LoadAssistQuestion()
        {
            // Database connection string
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

            // Add a new SQL database connection using the connectionString
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();
                // Add a query to select the questions, wrong answers and correct answer from the database
                // Order by NEWID() which sorts the question index randomly (built-in function)
                string query = "SELECT QuestionText, WrongAnswer1, CorrectAnswer FROM Questions ORDER BY NEWID()";
                // Declare a new SQLCommand using the query and connectionString
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Declare a new SQL data reader to fetch data from the database
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // While the reader is active
                        while (reader.Read())
                        {
                            // Fetch all data from the row the query was executed on
                            string assistQuestionText = reader.GetString(0);
                            string assistWrongAnswer1 = reader.GetString(1);
                            string assistWrongAnswer2 = "THIS IS WRONG.";
                            string assistWrongAnswer3 = "THIS IS WRONG.";
                            string assistCorrectAnswer = reader.GetString(2);

                            // Save the data into a List item
                            List<string> assistOptions = new List<string>
                            {
                                assistWrongAnswer1, assistWrongAnswer2, assistWrongAnswer3, assistCorrectAnswer
                            };

                            // Shuffle the options randomly
                            Random rng = new Random();
                            int assistOptionCount = assistOptions.Count;
                            // While there is more than 1 option, shuffle the questions randomly
                            while (assistOptionCount > 1)
                            {
                                // Decrement the options amount
                                assistOptionCount--;
                                // Declare a next option by returning a non-negative int
                                // and increment 1 to the total amount
                                int optionNext = rng.Next(assistOptionCount + 1);
                                // Save the value of the next option
                                string value = assistOptions[optionNext];
                                assistOptions[optionNext] = assistOptions[optionNext];
                                // Save the options into the value variable
                                assistOptions[optionNext] = value;
                            }
                            // Save the question as an object, add the previous data into the object
                            Question assistQuestion = new Question(assistQuestionText, assistOptions, assistCorrectAnswer);
                            assistQuestions.Add(assistQuestion);
                        }
                    }
                }
            }
        }

        private void DisplayAssistQuestion()
        {
            // Check if there are any questions left
            if (currentQuestionIndex < assistQuestions.Count)
            {
                // Get the previously added data from the questions object at the selected question index
                Question assistQuestion = assistQuestions[currentQuestionIndex];
                // Add the data to the form elements
                lblQuizQuestion.Text = assistQuestion.Text;
                rbOption1.Text = assistQuestion.Options[0];
                rbOption2.Text = assistQuestion.Options[1];
                rbOption3.Text = assistQuestion.Options[2];
                rbOption4.Text = assistQuestion.Options[3];
            }
            else
            {
                // Show a MessageBox saying the quiz has been completed
                MessageBox.Show("Quiz completed!");
            }
        }

        private void ClearSelection()
        {
            // Deselect all selected options
            rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = rbOption4.Checked = false;
        }

        private void btnResetQuiz_Click(object sender, EventArgs e)
        {
            // Exit the quiz and save the score into the leaderboard database table
            // If the user is in the top 10, display it in the quiz' final data leaderboard
            Application.Exit();
        }

        private void LoadTopScores()
        {
            try
            {
                connection.Open();

                string query = "SELECT TOP 10 Username, Score FROM Leaderboard ORDER BY Score DESC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader["Username"].ToString();
                    int score = Convert.ToInt32(reader["Score"]);
                    lbxLeaderboard.Items.Add($"Username: {username}, Score: {score}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check the selected answer and move to the next question
            if (rbOption1.Checked || rbOption2.Checked || rbOption3.Checked || rbOption4.Checked)
            {
                // Start the time left timer, save the selected answer into a string
                tmrTimeLeft.Start();
                // Evaluate the selected answer and save it into the string
                string selectedAnswer =
                rbOption1.Checked ? rbOption1.Text :
                rbOption2.Checked ? rbOption2.Text :
                rbOption3.Checked ? rbOption3.Text :
                rbOption4.Text;

                // Check if the answer was correct by getting the .CorrectAnswer value and comparing
                if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
                {
                    if (special == true)
                    {
                        // Increment the user's correct answers by 1
                        correctAnswers += 3;
                        lblCurrentScore.Text = correctAnswers.ToString();
                        // Display how many points the user got underneath the score indicator
                        lblScoreIndicator.Text = "+3";
                        lblScoreIndicator.ForeColor = Color.Green;
                        special = false;
                    }
                    else
                    {
                        // Increment the user's correct answers by 1
                        correctAnswers += 1;
                        // Add the user's current score into the score label (convert int to string)
                        lblCurrentScore.Text = correctAnswers.ToString();
                        // Display how many points the user got underneath the score indicator
                        lblScoreIndicator.Text = "+1";
                        lblScoreIndicator.ForeColor = Color.Green;

                    }
                }
                else
                {
                    // Add the user's current score into the score label (convert int to string)
                    lblCurrentScore.Text = correctAnswers.ToString();
                    // Display how many points the user got underneath the score indicator
                    lblScoreIndicator.Text = "";
                    lblScoreIndicator.ForeColor = Color.Red;
                    // Increment the user's wrong answers by 1
                    wrongAnswers += 1;
                    timeLeft += 5;
                }

                // Increment the question index, clear all selections, display a new question
                currentQuestionIndex++;
                ClearSelection();
                DisplayQuestion();
            }
            else
            {
                // Display a message asking the user to select an answer if selection is empty
                MessageBox.Show("Please select an answer!");
            }
        }

        private void btnAssist_Click(object sender, EventArgs e)
        {
            if (assistsLeft > 0)
            {
                assistsLeft--;
                // Increment the question index, clear all selections, display a new question
                currentQuestionIndex++;
                ClearSelection();
                DisplayAssistQuestion();
                lblAssistsLeft.Text = "Assists left: " + assistsLeft.ToString();
            }
            else
            {
                lblAssistIndicator.Text = "No assists left!";
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (skipsLeft > 0)
            {
                skipsLeft--;
                // Increment the question index, clear all selections, display a new question
                currentQuestionIndex++;
                ClearSelection();
                DisplayQuestion();
                lblSkipsLeft.Text = "Skips left: " + skipsLeft.ToString();
            }
            else
            {
                lblSkipIndicator.Text = "No skips left!";
            }
        }

        private void tmrTimeLeft_Tick(object sender, EventArgs e)
        {
            // Decrement the user's time left
            timeLeft++;
            lblTimeLeft.Text = "Time: " + timeLeft.ToString();
            // Remove the score indicator every second
            lblScoreIndicator.Text = "";
            lblSkipIndicator.Text = "";
            lblAssistIndicator.Text = "";
            // Check if the user has ran out of time
            if (correctAnswers >= 10)
            {
                // Stop the timer
                tmrTimeLeft.Stop();
                // Show a message saying the time has ran out
                MessageBox.Show("Quiz finished!");
                // Hide the quiz panel, display the data behind it
                pnlQuizFinished.Visible = false;
                // Add the user's data into the quiz' final data
                lblUsername.Text = _username + "'s score";
                lblFinalScore.Text = "Final score: " + currentScore.ToString();
                lblCorrectAnswers.Text = "Correct answers: " + correctAnswers.ToString();
                lblWrongAnswers.Text = "Wrong answers: " + wrongAnswers.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application when the exit button is clicked
            Application.Exit();
        }
    }
}
