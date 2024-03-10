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
    public partial class QuestionsAddForm : Form
    {
        public QuestionsAddForm()
        {
            InitializeComponent();
        }

        private void QuestionsAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddQuestionbutton_Click(object sender, EventArgs e)
        {
            if (!InputValidator.TryGetNumber(addAnswerTextBox.Text, out int newQuestionAnswer, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                var newQuestionText = addQuestionTextBox.Text;
                Game.AddQuestion(newQuestionText, newQuestionAnswer);
                Close();
            }
        }
    }
}
