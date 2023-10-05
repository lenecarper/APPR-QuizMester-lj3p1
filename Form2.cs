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
    public partial class Form2 : Form
    {
        int currentScore = 0;
        int timeLeft = 10;
        int correctAnswers = 0;
        int wrongAnswers = 0;
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private string _username;
        public Form2(string username)
        {
            InitializeComponent();
            LoadQuestionsFromDatabase();
            DisplayQuestion();
            _username = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblQuizQuestion.MaximumSize = new Size(250, 0);
            lblQuizQuestion.AutoSize = true;
            lblCurrentScore.Text = currentScore.ToString();
            ClearSelection();
            lblScoreIndicator.Text = "";
            lblTimeLeft.Text = timeLeft.ToString();
        }

        private void LoadQuestionsFromDatabase()
        {
            string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT QuestionText, WrongAnswer1, WrongAnswer2, WrongAnswer3, CorrectAnswer FROM Questions ORDER BY NEWID()";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string questionText = reader.GetString(0);
                            string wrongAnswer1 = reader.GetString(1);
                            string wrongAnswer2 = reader.GetString(2);
                            string wrongAnswer3 = reader.GetString(3);
                            string correctAnswer = reader.GetString(4);

                            List<string> options = new List<string>
                            {
                                wrongAnswer1, wrongAnswer2, wrongAnswer3, correctAnswer
                            };

                            // Shuffle the options randomly
                            Random rng = new Random();
                            int optionCount = options.Count;
                            while (optionCount > 1)
                            {
                                optionCount--;
                                int optionNext = rng.Next(optionCount + 1);
                                string value = options[optionNext];
                                options[optionNext] = options[optionNext];
                                options[optionNext] = value;
                            }

                            Question question = new Question(questionText, options, correctAnswer);
                            questions.Add(question);
                        }
                    }
                }
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question question = questions[currentQuestionIndex];
                lblQuizQuestion.Text = question.Text;
                rbOption1.Text = question.Options[0];
                rbOption2.Text = question.Options[1];
                rbOption3.Text = question.Options[2];
                rbOption4.Text = question.Options[3];
            }
            else
            {
                MessageBox.Show("Quiz completed!");
                // Handle quiz completion, e.g., show results or navigate to another form
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check the selected answer and move to the next question
            if (rbOption1.Checked || rbOption2.Checked || rbOption3.Checked || rbOption4.Checked)
            {
                tmrTimeLeft.Start();
                string selectedAnswer = rbOption1.Checked ? rbOption1.Text :
                                       rbOption2.Checked ? rbOption2.Text :
                                       rbOption3.Checked ? rbOption3.Text : rbOption4.Text;

                if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
                {
                    // Handle correct answer logic if needed
                    currentScore += 15;
                    lblCurrentScore.Text = currentScore.ToString();
                    lblScoreIndicator.Text = "+15";
                    lblScoreIndicator.ForeColor = Color.Green;
                    correctAnswers += 1;
                }
                else
                {
                    // Handle wrong answer logic if needed
                    currentScore -= 25;
                    lblCurrentScore.Text = currentScore.ToString();
                    lblScoreIndicator.Text = "-25";
                    lblScoreIndicator.ForeColor = Color.Red;
                    wrongAnswers += 1;
                }

                // Move to the next question
                currentQuestionIndex++;
                ClearSelection();
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("Please select an answer!");
            }
        }

        private void ClearSelection()
        {
            rbOption1.Checked = rbOption2.Checked = rbOption3.Checked = rbOption4.Checked = false;
        }

        private void tmrTimeLeft_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimeLeft.Text = timeLeft.ToString();
            lblScoreIndicator.Text = "";
            if (timeLeft == 0)
            {
                tmrTimeLeft.Stop();
                MessageBox.Show("Time's up, game over");
                pnlQuizFinished.Visible = false;
                lblUsername.Text = _username + "'s score";
                lblFinalScore.Text = "Final score: " + currentScore.ToString();
                lblCorrectAnswers.Text = "Correct answers: " + correctAnswers.ToString();
                lblWrongAnswers.Text = "Wrong answers: " + wrongAnswers.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetQuiz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
