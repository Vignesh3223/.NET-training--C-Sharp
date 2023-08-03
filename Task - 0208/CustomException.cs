using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task___0208
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string message):base($"Invalid Name :{message} (Name must contain only alphabets)") { }
    }
    internal class InvalidAvgScoreException : Exception
    {
        public InvalidAvgScoreException(string message):base($"Invalid Score :{message} (Average must be greater or equal to than 7)") { }
    }

    public class Trainee
    {
        public string Name;
        public double CSharpScore;
        public double UIScore;
        public double AverageScore;
        public int TotalScore;
    }
    internal class CustomException
    {
        static void Main(string[] args)
        {
            Trainee tr;
            try
            {
                Console.WriteLine("Enter Trainee Name: ");
                string Name = Console.ReadLine();
                tr = new Trainee();
                tr.Name = Name;
                ValidateName(tr);
                Console.WriteLine($"Trainee Name: {tr.Name}");
            }
            catch (InvalidNameException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Enter CSharp_Score (out of 10): ");
                double CSharpScore = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter UI_Score (out of 10): ");
                double UIScore = Convert.ToDouble(Console.ReadLine());
                tr = new Trainee();
                tr.TotalScore = 10;
                tr.CSharpScore = CSharpScore;
                tr.UIScore = UIScore;
                tr.AverageScore = (tr.CSharpScore + tr.UIScore) / 2;
                ValidateAvgScore(tr);
                Console.WriteLine("Average Mark");
                Console.WriteLine("--------------");
                Console.WriteLine($"Total Score: {tr.TotalScore}");
                Console.WriteLine($"Average Score: {tr.AverageScore}");
            }
            catch (InvalidAvgScoreException e1)
            {
                Console.WriteLine(e1.Message);
            }
            Console.ReadLine();
        }
        public static void ValidateName(Trainee trainee)
        {
            Regex regex = new Regex("^[A-Za-z_]+$");
            if (!regex.IsMatch(trainee.Name))
            {
                throw new InvalidNameException(trainee.Name);
            }
        }
        public static void ValidateAvgScore(Trainee trainee)
        { 
            if (trainee.AverageScore < 7)
            {
                throw new InvalidAvgScoreException(trainee.AverageScore.ToString());
            }
        }
    }
}
