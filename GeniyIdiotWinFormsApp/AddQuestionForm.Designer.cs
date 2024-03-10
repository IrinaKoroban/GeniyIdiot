namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsAddForm
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
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.AddQuestionLabel = new System.Windows.Forms.Label();
            this.addQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addAnswerTextBox = new System.Windows.Forms.TextBox();
            this.AddAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionButton.Location = new System.Drawing.Point(31, 268);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(186, 54);
            this.addQuestionButton.TabIndex = 0;
            this.addQuestionButton.Text = "Добавить вопрос";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.AddQuestionbutton_Click);
            // 
            // AddQuestionLabel
            // 
            this.AddQuestionLabel.AutoSize = true;
            this.AddQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddQuestionLabel.Location = new System.Drawing.Point(33, 31);
            this.AddQuestionLabel.Name = "AddQuestionLabel";
            this.AddQuestionLabel.Size = new System.Drawing.Size(158, 28);
            this.AddQuestionLabel.TabIndex = 1;
            this.AddQuestionLabel.Text = "Введите вопрос";
            // 
            // addQuestionTextBox
            // 
            this.addQuestionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionTextBox.Location = new System.Drawing.Point(33, 86);
            this.addQuestionTextBox.Name = "addQuestionTextBox";
            this.addQuestionTextBox.Size = new System.Drawing.Size(569, 34);
            this.addQuestionTextBox.TabIndex = 2;
            // 
            // addAnswerTextBox
            // 
            this.addAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAnswerTextBox.Location = new System.Drawing.Point(33, 199);
            this.addAnswerTextBox.Name = "addAnswerTextBox";
            this.addAnswerTextBox.Size = new System.Drawing.Size(184, 34);
            this.addAnswerTextBox.TabIndex = 3;
            // 
            // AddAnswerLabel
            // 
            this.AddAnswerLabel.AutoSize = true;
            this.AddAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAnswerLabel.Location = new System.Drawing.Point(31, 152);
            this.AddAnswerLabel.Name = "AddAnswerLabel";
            this.AddAnswerLabel.Size = new System.Drawing.Size(260, 28);
            this.AddAnswerLabel.TabIndex = 4;
            this.AddAnswerLabel.Text = "Введите правильный ответ";
            // 
            // QuestionsAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 380);
            this.Controls.Add(this.AddAnswerLabel);
            this.Controls.Add(this.addAnswerTextBox);
            this.Controls.Add(this.addQuestionTextBox);
            this.Controls.Add(this.AddQuestionLabel);
            this.Controls.Add(this.addQuestionButton);
            this.Name = "QuestionsAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вопрос";
            this.Load += new System.EventHandler(this.QuestionsAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addQuestionButton;
        private Label AddQuestionLabel;
        private TextBox addQuestionTextBox;
        private TextBox addAnswerTextBox;
        private Label AddAnswerLabel;
    }
}