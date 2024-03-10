using System;
using Newtonsoft.Json;


namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public int RightAnswersCount { get; set; }
        public string Diagnose { get; set; }

        public User()
        { }
        public User(string name)
        {
            Name = name;
            Diagnose = "неизвестно";
        }
        public User(string name, int rightAnswersCount, string diagnose)
        {
            Name = name;
            RightAnswersCount = rightAnswersCount;
            Diagnose = diagnose;
        }

        public void AcceptRightAnswer()
        {
            RightAnswersCount++;
        }
    }
}
