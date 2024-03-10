using System;
using System.Collections.Generic;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{

    internal class Program
    {
        static void Main()
        {
            var userChoiceYesNo = true;

            while (userChoiceYesNo)
            {
                var user = new User(GetUserName());
                var game = new Game(user);

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();

                    Console.WriteLine(game.GetQuestionNumberText());
                    Console.WriteLine(currentQuestion.Text);

                    var userAnswer = GetNumber();
                    game.AcceptUserAnswer(userAnswer);

                }

                var message = game.CalculateDiagnose();

                Console.WriteLine(message);

                userChoiceYesNo = GetUserChoice("Вы хотите посмотреть таблицу результатов теста? Ответ: да или нет");
                if (userChoiceYesNo)
                    ShowTestResults();

                userChoiceYesNo = GetUserChoice("Вы хотите добавить новый вопрос?  Ответ: да или нет");
                if (userChoiceYesNo)
                    AddNewQuestion();

                userChoiceYesNo = GetUserChoice("Вы хотите удалить вопрос из теста?  Ответ: да или нет");
                if (userChoiceYesNo)
                    RemoveQuestion();

                userChoiceYesNo = GetUserChoice("Вы хотите повторить тест? Ответ: да или нет");
            }
        }


        static string GetUserName()
        {
            var userNameMaxLength = 30;
            var userName = "";

            Console.WriteLine($"Здравствуйте! Введите ваши фамилию, имя и отчество. Ограничение до {userNameMaxLength} знаков");
            while (true)
            {
                userName = Console.ReadLine();
                if (userName == "")
                    Console.WriteLine("Введите ваше ФИО, пожалуйста.");
                else
                    break;
            }

            if (userName.Length > userNameMaxLength)
            {
                userName = userName.Substring(0, userNameMaxLength);
                Console.WriteLine();
                Console.WriteLine($"Внимание! Вы ввели больше {userNameMaxLength} знаков.");
                Console.WriteLine($"Ваше ФИО сократится до {userName}");
                Console.WriteLine();
            }

            return userName;
        }

        static int GetNumber()
        {
            int number;
            while (!InputValidator.TryGetNumber(Console.ReadLine(), out number, out string errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            return number;
        }

        static bool GetUserChoice(string message)
        {
            Console.WriteLine(message);
            var userAnswer = Console.ReadLine().ToLower();

            while (userAnswer != "да" && userAnswer != "нет")
            {
                Console.WriteLine("Вы ввели неверный ответ. Введите да или нет");
                userAnswer = Console.ReadLine().ToLower();
            }
            return userAnswer == "да";
        }


        static void ShowTestResults()
        {
            var usersResults = Game.GetAllResults();
            var tableBorder = new string('*', 75);
            var tableFormat = "* {0, 30} * {1, 25} * {2, 10} *";
            var tableHeader = string.Format(tableFormat, "ФИО", "Кол-во правильных ответов", "Диагноз");

            Console.WriteLine();
            Console.WriteLine(tableBorder);
            Console.WriteLine(tableHeader);
            Console.WriteLine(tableBorder);

            foreach (var result in usersResults)
            {
                var userResultRow = string.Format(tableFormat, result.Name, result.RightAnswersCount, result.Diagnose);
                Console.WriteLine(userResultRow);
            }
            Console.WriteLine(tableBorder);
        }

        static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса:");
            var questionText = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос:");
            var answer = GetNumber();
            Game.AddQuestion(questionText, answer);
        }

        public static void RemoveQuestion()
        {
            var questions = Game.GetAllQuestions();
            Console.WriteLine("Введите номер удаляемого вопроса");

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"№ {i + 1} {questions[i].Text}");
            }
            var removeQuestionNumber = GetQuestionNumber();
            var message = Game.RemoveQuestion(removeQuestionNumber);

            Console.WriteLine(message);
        }

        static int GetQuestionNumber()
        {
            while (true)
            {
                var questionNumber = GetNumber();
                if (!InputValidator.TryGetQuestion(questionNumber, out string errorDeleteQuestionMessage))
                {
                    Console.WriteLine(errorDeleteQuestionMessage);
                }
                else
                {
                    return questionNumber;
                }
            }
        }
    }
}
