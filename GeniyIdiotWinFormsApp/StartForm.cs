using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            startGameButton.Enabled = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! У вас есть только 10 секунд на один вопрос." +
                "\nОтветом является число. \nПока вы не нажали кнопку Далее, ответ не будет засчитан.", "Правила игры");

            var gameForm = new GameForm(userNameTextBox.Text);
            gameForm.Show();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            startGameButton.Enabled = userNameTextBox.Text.Length >= 2;
        }
    }
}
