namespace GeniyIdiot.Common
{
    public class Diagnose
    {
        public static string[] GetDiagnoses()
        {
            return new string[] { "Идиот", "Кретин", "Дурак", "Нормальный", "Талант", "Гений" };
        }

        public static string CalculateDiagnose(int questionsCount, int rightAnswersCount)
        {
            var diagnoses = GetDiagnoses();
            var diagnosesNumber = diagnoses.Length;
            var userDiagnose = "";

            var rightAnswersPercentage = (double)rightAnswersCount * 100 / (double)questionsCount;
            var graduationStep = 100 / (double)diagnosesNumber;

            for (int i = 0; i < diagnosesNumber; i++)
            {
                if (rightAnswersPercentage <= graduationStep * (i + 1))
                {
                    userDiagnose = diagnoses[i];
                    break;
                }
            }
            return userDiagnose;
        }
    }
}
