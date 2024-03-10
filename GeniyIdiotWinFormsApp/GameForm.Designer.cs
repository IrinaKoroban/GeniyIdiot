namespace GeniyIdiotWinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.informingLabel = new System.Windows.Forms.Label();
            this.testMenuStrip = new System.Windows.Forms.MenuStrip();
            this.gameMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerInfoLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.testMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.Location = new System.Drawing.Point(27, 57);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(102, 25);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "Вопрос №";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTextLabel.Location = new System.Drawing.Point(27, 114);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(146, 25);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(27, 320);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(139, 45);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userAnswerTextBox.Location = new System.Drawing.Point(27, 241);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(199, 30);
            this.userAnswerTextBox.TabIndex = 3;
            // 
            // informingLabel
            // 
            this.informingLabel.AutoSize = true;
            this.informingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informingLabel.Location = new System.Drawing.Point(27, 191);
            this.informingLabel.Name = "informingLabel";
            this.informingLabel.Size = new System.Drawing.Size(199, 25);
            this.informingLabel.TabIndex = 4;
            this.informingLabel.Text = "Введите ваш ответ:";
            // 
            // testMenuStrip
            // 
            this.testMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.questionsToolStripMenuItem});
            this.testMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.testMenuStrip.Name = "testMenuStrip";
            this.testMenuStrip.Size = new System.Drawing.Size(813, 31);
            this.testMenuStrip.TabIndex = 5;
            this.testMenuStrip.Text = "menuStrip1";
            // 
            // gameMenuToolStripMenuItem
            // 
            this.gameMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAgainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameMenuToolStripMenuItem.Name = "gameMenuToolStripMenuItem";
            this.gameMenuToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.gameMenuToolStripMenuItem.Text = "Меню теста";
            // 
            // startAgainToolStripMenuItem
            // 
            this.startAgainToolStripMenuItem.Name = "startAgainToolStripMenuItem";
            this.startAgainToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.startAgainToolStripMenuItem.Text = "Начать с начала";
            this.startAgainToolStripMenuItem.Click += new System.EventHandler(this.startAgainToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameResultsToolStripMenuItem});
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(157, 27);
            this.resultsToolStripMenuItem.Text = "Результаты теста";
            // 
            // gameResultsToolStripMenuItem
            // 
            this.gameResultsToolStripMenuItem.Name = "gameResultsToolStripMenuItem";
            this.gameResultsToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.gameResultsToolStripMenuItem.Text = "Посмотреть результаты";
            this.gameResultsToolStripMenuItem.Click += new System.EventHandler(this.gameResultsToolStripMenuItem_Click);
            // 
            // questionsToolStripMenuItem
            // 
            this.questionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem,
            this.deleteQuestionToolStripMenuItem});
            this.questionsToolStripMenuItem.Name = "questionsToolStripMenuItem";
            this.questionsToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.questionsToolStripMenuItem.Text = "Вопросы";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.addQuestionToolStripMenuItem.Text = "Добавить вопрос";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // deleteQuestionToolStripMenuItem
            // 
            this.deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            this.deleteQuestionToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.deleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            this.deleteQuestionToolStripMenuItem.Click += new System.EventHandler(this.deleteQuestionToolStripMenuItem_Click);
            // 
            // timerInfoLabel
            // 
            this.timerInfoLabel.AutoSize = true;
            this.timerInfoLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerInfoLabel.Location = new System.Drawing.Point(421, 55);
            this.timerInfoLabel.Name = "timerInfoLabel";
            this.timerInfoLabel.Size = new System.Drawing.Size(111, 31);
            this.timerInfoLabel.TabIndex = 6;
            this.timerInfoLabel.Text = "Осталось";
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(538, 50);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(245, 50);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "таймер";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 394);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerInfoLabel);
            this.Controls.Add(this.informingLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.testMenuStrip);
            this.MainMenuStrip = this.testMenuStrip;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.GameForm1_Load);
            this.testMenuStrip.ResumeLayout(false);
            this.testMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label questionNumberLabel;
        private Label questionTextLabel;
        private Button nextButton;
        private TextBox userAnswerTextBox;
        private Label informingLabel;
        private MenuStrip testMenuStrip;
        private ToolStripMenuItem gameMenuToolStripMenuItem;
        private ToolStripMenuItem startAgainToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem resultsToolStripMenuItem;
        private ToolStripMenuItem gameResultsToolStripMenuItem;
        private ToolStripMenuItem questionsToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
        private ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private Label timerInfoLabel;
        public Label timerLabel;
        private System.Windows.Forms.Timer timer;
    }
}