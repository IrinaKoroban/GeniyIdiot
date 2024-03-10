using System;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string path = "questions.json";
        public static List<Question> GetAllQuestions()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(path) && FileProvider.CheckFileNotEmpty(path))
            {
                var fileData = FileProvider.GetValue(path);
                questions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                SaveQuestions(questions);
            }
            return questions;
        }

        public static void SaveQuestions(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }

        public static void Append(Question newQuestion)
        {
            var questions = GetAllQuestions();
            questions.Add(newQuestion);
            SaveQuestions(questions);
        }
    }
}
