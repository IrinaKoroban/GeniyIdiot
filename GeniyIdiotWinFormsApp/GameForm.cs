using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class GameForm : Form
    {
        Game game;
        string userName;
        int timerValue = 10;
        int timeLeft;

        public GameForm(string text)
        {
            InitializeComponent();
            userName = text;
        }

        private void GameForm1_Load(object sender, EventArgs e)
        {

            resultsToolStripMenuItem.Enabled = false;
            questionsToolStripMenuItem.Enabled = false;

            var user = new User(userName);
            game = new Game(user);


            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
 
                var currentQuestion = game.GetNextQuestion();

                questionTextLabel.Text = currentQuestion.Text;
                questionNumberLabel.Text = game.GetQuestionNumberText();

                timeLeft = timerValue;
                timerLabel.Text = timeLeft + " секунд";
                timer.Start();

        }

        private void ShowResults()
        {
            var message = game.CalculateDiagnose();
            MessageBox.Show(message);

            nextButton.Enabled = false;
            resultsToolStripMenuItem.Enabled = true;
            questionsToolStripMenuItem.Enabled = true;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!InputValidator.TryGetNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                timer.Stop();
                game.AcceptUserAnswer(userAnswer);

                userAnswerTextBox.Clear();

                if (game.End())
                {
                    ShowResults();
                    return;
                }
                ShowNextQuestion();
            }
        }

        private void startAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm();
            userResultsForm.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionsAddForm = new QuestionsAddForm();
            questionsAddForm.ShowDialog();
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.ShowDialog();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timerLabel.Text = timeLeft + " секунд";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Вы не успели ответить!");

                game.GetNoAnswer();
                userAnswerTextBox.Clear();
                ShowNextQuestion();
            }
        }
    }
}
