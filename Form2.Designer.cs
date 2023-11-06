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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCurrentScoreHolder = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTimeLeftHolder = new System.Windows.Forms.Label();
            this.lblScoreIndicator = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tmrTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.pnlQuizFinished = new System.Windows.Forms.Panel();
            this.lblSkipIndicator = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lblSkipsLeft = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnFinishQuiz = new System.Windows.Forms.Button();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.pnlLeaderboard = new System.Windows.Forms.Panel();
            this.lbxLeaderboard = new System.Windows.Forms.ListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAssist = new System.Windows.Forms.Button();
            this.lblAssistIndicator = new System.Windows.Forms.Label();
            this.lblAssistsLeft = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblQuizQuestion = new System.Windows.Forms.Label();
            this.pcbQuizIcon = new System.Windows.Forms.PictureBox();
            this.btnPowerpoint = new System.Windows.Forms.Button();
            this.pnlQuizFinished.SuspendLayout();
            this.pnlLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuizIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentScoreHolder
            // 
            this.lblCurrentScoreHolder.AutoSize = true;
            this.lblCurrentScoreHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCurrentScoreHolder.Location = new System.Drawing.Point(-5, 247);
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
            this.lblCurrentScore.Location = new System.Drawing.Point(173, 247);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(27, 29);
            this.lblCurrentScore.TabIndex = 14;
            this.lblCurrentScore.Text = "0";
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbOption1.Location = new System.Drawing.Point(417, 256);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(149, 40);
            this.rbOption1.TabIndex = 15;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "Option 1";
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbOption2.Location = new System.Drawing.Point(757, 256);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(149, 40);
            this.rbOption2.TabIndex = 16;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "Option 2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbOption3.Location = new System.Drawing.Point(417, 341);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(149, 40);
            this.rbOption3.TabIndex = 17;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "Option 3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rbOption4.Location = new System.Drawing.Point(757, 341);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(149, 40);
            this.rbOption4.TabIndex = 18;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "Option 4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(560, 465);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(234, 74);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Confirm";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTimeLeftHolder
            // 
            this.lblTimeLeftHolder.AutoSize = true;
            this.lblTimeLeftHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeftHolder.ForeColor = System.Drawing.Color.White;
            this.lblTimeLeftHolder.Location = new System.Drawing.Point(-3, 519);
            this.lblTimeLeftHolder.Name = "lblTimeLeftHolder";
            this.lblTimeLeftHolder.Size = new System.Drawing.Size(131, 32);
            this.lblTimeLeftHolder.TabIndex = 20;
            this.lblTimeLeftHolder.Text = "Time left:";
            // 
            // lblScoreIndicator
            // 
            this.lblScoreIndicator.AutoSize = true;
            this.lblScoreIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblScoreIndicator.Location = new System.Drawing.Point(173, 276);
            this.lblScoreIndicator.Name = "lblScoreIndicator";
            this.lblScoreIndicator.Size = new System.Drawing.Size(138, 25);
            this.lblScoreIndicator.TabIndex = 21;
            this.lblScoreIndicator.Text = "score indicator";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.White;
            this.lblTimeLeft.Location = new System.Drawing.Point(124, 522);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(59, 29);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.Text = "time";
            // 
            // tmrTimeLeft
            // 
            this.tmrTimeLeft.Interval = 1000;
            this.tmrTimeLeft.Tick += new System.EventHandler(this.tmrTimeLeft_Tick);
            // 
            // pnlQuizFinished
            // 
            this.pnlQuizFinished.Controls.Add(this.lblAssistsLeft);
            this.pnlQuizFinished.Controls.Add(this.lblAssistIndicator);
            this.pnlQuizFinished.Controls.Add(this.btnAssist);
            this.pnlQuizFinished.Controls.Add(this.lblSkipIndicator);
            this.pnlQuizFinished.Controls.Add(this.btnSkip);
            this.pnlQuizFinished.Controls.Add(this.lblSkipsLeft);
            this.pnlQuizFinished.Controls.Add(this.pcbLogo);
            this.pnlQuizFinished.Controls.Add(this.lblTimeLeft);
            this.pnlQuizFinished.Controls.Add(this.btnExit);
            this.pnlQuizFinished.Controls.Add(this.lblCurrentScoreHolder);
            this.pnlQuizFinished.Controls.Add(this.lblTimeLeftHolder);
            this.pnlQuizFinished.Controls.Add(this.lblScoreIndicator);
            this.pnlQuizFinished.Controls.Add(this.btnNext);
            this.pnlQuizFinished.Controls.Add(this.lblCurrentScore);
            this.pnlQuizFinished.Controls.Add(this.rbOption4);
            this.pnlQuizFinished.Controls.Add(this.pnlBackground);
            this.pnlQuizFinished.Controls.Add(this.rbOption3);
            this.pnlQuizFinished.Controls.Add(this.rbOption1);
            this.pnlQuizFinished.Controls.Add(this.rbOption2);
            this.pnlQuizFinished.Location = new System.Drawing.Point(12, 0);
            this.pnlQuizFinished.Name = "pnlQuizFinished";
            this.pnlQuizFinished.Size = new System.Drawing.Size(1092, 560);
            this.pnlQuizFinished.TabIndex = 24;
            this.pnlQuizFinished.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.pnlQuizFinished.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.pnlQuizFinished.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // lblSkipIndicator
            // 
            this.lblSkipIndicator.AutoSize = true;
            this.lblSkipIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkipIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblSkipIndicator.Location = new System.Drawing.Point(795, 436);
            this.lblSkipIndicator.Name = "lblSkipIndicator";
            this.lblSkipIndicator.Size = new System.Drawing.Size(125, 25);
            this.lblSkipIndicator.TabIndex = 26;
            this.lblSkipIndicator.Text = "skip indicator";
            // 
            // btnSkip
            // 
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSkip.FlatAppearance.BorderSize = 2;
            this.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(800, 465);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(234, 74);
            this.btnSkip.TabIndex = 25;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // lblSkipsLeft
            // 
            this.lblSkipsLeft.AutoSize = true;
            this.lblSkipsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkipsLeft.ForeColor = System.Drawing.Color.White;
            this.lblSkipsLeft.Location = new System.Drawing.Point(-3, 481);
            this.lblSkipsLeft.Name = "lblSkipsLeft";
            this.lblSkipsLeft.Size = new System.Drawing.Size(161, 32);
            this.lblSkipsLeft.TabIndex = 24;
            this.lblSkipsLeft.Text = "Skips left: 0";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFinalScore.Location = new System.Drawing.Point(748, 87);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(256, 42);
            this.lblFinalScore.TabIndex = 25;
            this.lblFinalScore.Text = "Final score: 0";
            // 
            // btnFinishQuiz
            // 
            this.btnFinishQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishQuiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFinishQuiz.FlatAppearance.BorderSize = 2;
            this.btnFinishQuiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFinishQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnFinishQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishQuiz.ForeColor = System.Drawing.Color.White;
            this.btnFinishQuiz.Location = new System.Drawing.Point(722, 359);
            this.btnFinishQuiz.Name = "btnFinishQuiz";
            this.btnFinishQuiz.Size = new System.Drawing.Size(282, 74);
            this.btnFinishQuiz.TabIndex = 26;
            this.btnFinishQuiz.Text = "SAVE AND EXIT";
            this.btnFinishQuiz.UseVisualStyleBackColor = true;
            this.btnFinishQuiz.Click += new System.EventHandler(this.btnResetQuiz_Click);
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(697, 151);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(349, 42);
            this.lblCorrectAnswers.TabIndex = 27;
            this.lblCorrectAnswers.Text = "Correct answers: 0";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWrongAnswers.Location = new System.Drawing.Point(697, 222);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(335, 42);
            this.lblWrongAnswers.TabIndex = 28;
            this.lblWrongAnswers.Text = "Wrong answers: 0";
            // 
            // pnlLeaderboard
            // 
            this.pnlLeaderboard.Controls.Add(this.lbxLeaderboard);
            this.pnlLeaderboard.Location = new System.Drawing.Point(12, 12);
            this.pnlLeaderboard.Name = "pnlLeaderboard";
            this.pnlLeaderboard.Size = new System.Drawing.Size(485, 548);
            this.pnlLeaderboard.TabIndex = 29;
            // 
            // lbxLeaderboard
            // 
            this.lbxLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbxLeaderboard.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLeaderboard.ForeColor = System.Drawing.Color.Purple;
            this.lbxLeaderboard.FormattingEnabled = true;
            this.lbxLeaderboard.ItemHeight = 36;
            this.lbxLeaderboard.Location = new System.Drawing.Point(18, 26);
            this.lbxLeaderboard.Name = "lbxLeaderboard";
            this.lbxLeaderboard.Size = new System.Drawing.Size(454, 508);
            this.lbxLeaderboard.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUsername.Location = new System.Drawing.Point(774, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(198, 42);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            // 
            // btnAssist
            // 
            this.btnAssist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAssist.FlatAppearance.BorderSize = 2;
            this.btnAssist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnAssist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAssist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssist.ForeColor = System.Drawing.Color.White;
            this.btnAssist.Location = new System.Drawing.Point(320, 465);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(234, 74);
            this.btnAssist.TabIndex = 27;
            this.btnAssist.Text = "Assist";
            this.btnAssist.UseVisualStyleBackColor = true;
            this.btnAssist.Click += new System.EventHandler(this.btnAssist_Click);
            // 
            // lblAssistIndicator
            // 
            this.lblAssistIndicator.AutoSize = true;
            this.lblAssistIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistIndicator.ForeColor = System.Drawing.Color.Red;
            this.lblAssistIndicator.Location = new System.Drawing.Point(315, 436);
            this.lblAssistIndicator.Name = "lblAssistIndicator";
            this.lblAssistIndicator.Size = new System.Drawing.Size(140, 25);
            this.lblAssistIndicator.TabIndex = 28;
            this.lblAssistIndicator.Text = "assist indicator";
            // 
            // lblAssistsLeft
            // 
            this.lblAssistsLeft.AutoSize = true;
            this.lblAssistsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistsLeft.ForeColor = System.Drawing.Color.White;
            this.lblAssistsLeft.Location = new System.Drawing.Point(-3, 444);
            this.lblAssistsLeft.Name = "lblAssistsLeft";
            this.lblAssistsLeft.Size = new System.Drawing.Size(181, 32);
            this.lblAssistsLeft.TabIndex = 29;
            this.lblAssistsLeft.Text = "Assists left: 0";
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = global::APPR_QuizMester_lj3p1.Properties.Resources.Logo;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Location = new System.Drawing.Point(0, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(243, 230);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.Location = new System.Drawing.Point(1054, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 35);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBackground.Controls.Add(this.lblQuizQuestion);
            this.pnlBackground.Controls.Add(this.pcbQuizIcon);
            this.pnlBackground.Location = new System.Drawing.Point(356, 90);
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
            // btnPowerpoint
            // 
            this.btnPowerpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerpoint.ForeColor = System.Drawing.Color.White;
            this.btnPowerpoint.Image = ((System.Drawing.Image)(resources.GetObject("btnPowerpoint.Image")));
            this.btnPowerpoint.Location = new System.Drawing.Point(704, 444);
            this.btnPowerpoint.Name = "btnPowerpoint";
            this.btnPowerpoint.Size = new System.Drawing.Size(316, 116);
            this.btnPowerpoint.TabIndex = 31;
            this.btnPowerpoint.Text = "Click here to appreciate mr. Sprong";
            this.btnPowerpoint.UseVisualStyleBackColor = true;
            this.btnPowerpoint.Click += new System.EventHandler(this.btnPowerpoint_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1099, 572);
            this.Controls.Add(this.pnlQuizFinished);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btnFinishQuiz);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.pnlLeaderboard);
            this.Controls.Add(this.btnPowerpoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlQuizFinished.ResumeLayout(false);
            this.pnlQuizFinished.PerformLayout();
            this.pnlLeaderboard.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblCurrentScoreHolder;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.RadioButton rbOption1;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTimeLeftHolder;
        private System.Windows.Forms.Label lblScoreIndicator;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer tmrTimeLeft;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlQuizFinished;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnFinishQuiz;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Panel pnlLeaderboard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ListBox lbxLeaderboard;
        private System.Windows.Forms.Label lblSkipsLeft;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label lblSkipIndicator;
        private System.Windows.Forms.Button btnPowerpoint;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.Label lblAssistIndicator;
        private System.Windows.Forms.Label lblAssistsLeft;
    }
}