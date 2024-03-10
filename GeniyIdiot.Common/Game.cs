using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        int questionNumber = 0;
        int questionCount;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAllQuestions();
            questionCount = questions.Count;
        }

        public static List<Question> GetAllQuestions()
        {
            return QuestionsStorage.GetAllQuestions();
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);

            currentQuestion = questions[randomIndex];
            return currentQuestion;
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос №" + (++questionNumber);
        }

        public void AcceptUserAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
                user.AcceptRightAnswer();

            questions.Remove(currentQuestion);
        }
        public string CalculateDiagnose()
        {
            user.Diagnose = Diagnose.CalculateDiagnose(questionCount, user.RightAnswersCount);
            UsersResultStorage.Append(user);
            return user.Name + ", ваш диагноз - " + user.Diagnose;
        }

        public bool End()
        {
            return questions.Count == 0;
        }
        public static List<User> GetAllResults()
        {
            return UsersResultStorage.GetAll();
        }

        public static void AddQuestion(string newQuestionText, int newQuestionAnswer)
        {
            var newQuestion = new Question(newQuestionText, newQuestionAnswer);
            QuestionsStorage.Append(newQuestion);
        }

        public static string RemoveQuestion(int removeQuestionNumber)
        {
            var questions = QuestionsStorage.GetAllQuestions();

            var removeQuestion = questions[removeQuestionNumber - 1];
            questions.Remove(removeQuestion);
            QuestionsStorage.SaveQuestions(questions);
            
            if (questions.Count == 0)
            {
                return "Вопросов в тесте не осталось, вопросы будут перезаписаны из базовых.";
            }
            else
            {
                return "Вопрос был удалён";
            }
        }

        public void GetNoAnswer()
        {
            questions.Remove(currentQuestion);
        }
    }
}

