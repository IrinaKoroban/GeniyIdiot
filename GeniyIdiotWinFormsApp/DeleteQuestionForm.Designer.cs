namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Location = new System.Drawing.Point(27, 30);
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidth = 51;
            this.questionsDataGridView.RowTemplate.Height = 29;
            this.questionsDataGridView.Size = new System.Drawing.Size(835, 270);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.Location = new System.Drawing.Point(54, 332);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(361, 28);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Введите номер вопроса для удаления";
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestionButton.Location = new System.Drawing.Point(54, 399);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(188, 39);
            this.deleteQuestionButton.TabIndex = 3;
            this.deleteQuestionButton.Text = "удалить вопрос";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 475);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionsDataGridView);
            this.Name = "DeleteQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление вопроса";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView questionsDataGridView;
        private Label questionNumberLabel;
        private Button deleteQuestionButton;
    }
}