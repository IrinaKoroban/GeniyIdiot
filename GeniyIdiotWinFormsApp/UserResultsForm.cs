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
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm1_Load(object sender, EventArgs e)
        {
            userResultsDataGridView.AllowUserToAddRows = false;

            var usersResults = Game.GetAllResults();

            var userResultsTable = new DataTable();

            userResultsTable.Columns.Add("ФИО", typeof(string));
            userResultsTable.Columns.Add("Кол-во правильных ответов", typeof(int));
            userResultsTable.Columns.Add("Диагноз", typeof(string));

            foreach (var user in usersResults)
            {
                userResultsTable.Rows.Add(user.Name, user.RightAnswersCount, user.Diagnose);
            }

            userResultsDataGridView.DataSource = userResultsTable;
        }
    }
}
