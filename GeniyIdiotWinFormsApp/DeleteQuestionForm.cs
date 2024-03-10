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
    public partial class DeleteQuestionForm : Form
    {
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            questionsDataGridView.AllowUserToAddRows = false;
            questionNumberLabel.Text = "Выберите строку с вопросом для удаления";

            var questionsTable = new DataTable();
            var questions = Game.GetAllQuestions();

            questionsTable.Columns.Add("Номер вопроса", typeof(int));
            questionsTable.Columns.Add("Вопрос", typeof(string));
            questionsTable.Columns.Add("Ответ", typeof(int));

            for (int i = 0; i < questions.Count; i++)
            {
                questionsTable.Rows.Add(i + 1, questions[i].Text, questions[i].Answer);
            }
            questionsDataGridView.DataSource = questionsTable;
        }


        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = questionsDataGridView.SelectedRows[0].Index + 1;
                var message = Game.RemoveQuestion(selectedRowIndex);
                MessageBox.Show(message);
                Close();
            }
        }
    }
}
