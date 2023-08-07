using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_File1
{
        public class FileDemo
        {
            public int id;
            public string name;
            public string city;
            public string TraineeDetails;

            public void GetDetails()
            {
                Console.WriteLine("Enter Trainee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Trainee City : ");
                city = Console.ReadLine();
                TraineeDetails += ($"\nTrainee {name}'s id is {id} and trainee is from {city}");
            }
            public void Details()
            {
                FileInfo fileInfo = new FileInfo(@"E:\Naveen\Task-File1\DotNet.txt");
                FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                try
                {
                    streamWriter.WriteLine(TraineeDetails);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    streamWriter.Close();
                    fileStream.Close();
                }
            }
            public void Append()
            {
                FileInfo fileInfo = new FileInfo(@"E:\Naveen\Task-File1\DotNet.txt");
                FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                try
                {
                    Console.WriteLine("Enter Trainee ID : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Trainee Name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Trainee City : ");
                    city = Console.ReadLine();
                    streamWriter.WriteLine($"Appended - Trainee {name}'s id is {id} and trainee is from {city}");
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1.Message);
                }
                finally
                {
                    streamWriter.Close();
                    fileStream.Close();
                }
            }
            public void Read()
            {
                FileInfo fileInfo = new FileInfo(@"E:\Naveen\Task-File1\DotNet.txt");
                FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader streamReader = new StreamReader(fileStream);
                try
                {
                    string data = streamReader.ReadToEnd();
                    Console.WriteLine(data + "\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    streamReader.Close();
                    fileStream.Close();
                    Console.WriteLine("File created and Data read");
                }
            }
        public void CopyFileMethod()
        {
            string sourceFile = @"E:\Naveen\Task-File1\DotNet.txt";
            string CopyFile = @"E:\Naveen\Task-File1\DotNetCopy.txt";
            try
            {
                File.Copy(sourceFile, CopyFile);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            Console.WriteLine("File Contents Copied Successfully");
        }
        public void MoveFileMethod()
        {
            string CopyFile = @"E:\Naveen\Task-File1\DotNetCopy.txt";
            string MoveFile = @"E:\Naveen\Task-File1\DotNetMove.txt";
            try
            {
                File.Move(CopyFile, MoveFile);
            }
            catch (Exception e3)
            {
                Console.WriteLine(e3.Message);
            }
            Console.WriteLine("File Contents Moved Successfully");
        }
    }

    internal class FileOperations
    {
        static void Main(string[] args)
            {
                FileDemo demo = new FileDemo();
                Console.WriteLine("Enter Trainee Details to Insert");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter Number of Trainees: ");
                int count = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    demo.GetDetails();
                }
                demo.Details();
                Console.WriteLine("********************************");
                Console.WriteLine("Enter Trainee Details to Append");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Enter Number of Trainees: ");
                int count1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count1; i++)
                {
                    demo.Append();
                }
                demo.Read();
                demo.CopyFileMethod();
                demo.MoveFileMethod();
                Console.ReadLine();
            }
        }
    }
