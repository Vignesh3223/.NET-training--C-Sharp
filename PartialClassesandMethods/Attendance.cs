using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassesandMethods
{
      struct TraineeAttendance
    {
        public int Id;
        public string Name;
        public string Attendance;

        public void GetAttendance()
        {
            Console.WriteLine("Enter Trainee ID : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Attendance (Present / Absent) : ");
            Attendance = Console.ReadLine();
        }
        public void DisplayAttendance()
        {
            Console.WriteLine($"{Id}\t{Name}\t\t{Attendance}");
        }
    }
    internal class Attendance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trainees : ");
            int count = Convert.ToInt32(Console.ReadLine());
            TraineeAttendance[] trainees = new TraineeAttendance[count];
            int presentcount = 0;
            int absentcount = 0;
            for (int i = 0; i < count; i++)
            {
                trainees[i].GetAttendance();
                if (trainees[i].Attendance.ToLower() == "present")
                {
                    presentcount++;
                }
                else if (trainees[i].Attendance.ToLower() == "absent")
                {
                    absentcount++;
                }
            }
            Console.WriteLine("\nTrainee Attendance");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Id\tName\t\tAttendance");
            foreach (var trainee in trainees)
            {
                trainee.DisplayAttendance();
            }
            Console.WriteLine("\nAttendance Count");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Total number of Trainees : {count}");
            Console.WriteLine($"Total number of Present : {presentcount}");
            Console.WriteLine($"Total number of Absent : {absentcount}");
            Console.ReadLine();
        }
    }
}
