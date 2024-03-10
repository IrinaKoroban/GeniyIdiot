using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryGetNumber(string input, out int number, out string errorMessage)
        {
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(input);
                    errorMessage = "";
                    return true;

                }
                catch (FormatException)
                {
                    number = 0;
                    errorMessage = "Пожалуйста, введите число";
                    return false;
                }
                catch (OverflowException)
                {
                    number = 0;
                    errorMessage = "Вы ввели слишком длинный ответ! Ответом считается -2*10^9 до 2*10^9";
                    return false;
                }
            }
        }
        public static bool TryGetQuestion(int removeQuestionNumber, out string errorDeleteQuestionMessage)
        {
            var questions = Game.GetAllQuestions();
            errorDeleteQuestionMessage = "";

            if (removeQuestionNumber < 0 || removeQuestionNumber > questions.Count)
            {
                errorDeleteQuestionMessage = "Вы выбрали не то число.";
                return false;
            }

            return true;
        }
    }
}
