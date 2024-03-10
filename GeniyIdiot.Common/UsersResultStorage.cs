using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;


namespace GeniyIdiot.Common
{

    public class UsersResultStorage
    {
        private static string path = "test results.json";

        public UsersResultStorage()
        {
            var users = new List<User>();
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(path))
            {
                return new List<User>();
            }

            var fileData = FileProvider.GetValue(path);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return usersResults;
        }

        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }

        public static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
    }
}
