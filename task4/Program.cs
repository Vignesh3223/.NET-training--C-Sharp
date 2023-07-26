using System;
public abstract class Person
{
    public string name;
    public string gender;
    public string address;
    public DateTime dob;
    public long contact_number;
    public Person()
    { }
  
    public static int CalculateAge(DateTime dateOfBirth)
    {
        int age = 0;
        age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age = age - 1;
        return age;
    }

    public abstract void accept();
    public abstract void display();
}
public class Student : Person
{
    public int rollno;
    public int grade;
    public float mark1;
    public float mark2;
    public float mark3;
    public float total;
    public float average;
    public string result;
    public Student():base()
    { }
    public override void accept()
    {
        Console.WriteLine("Enter the Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the Gender : ");
        string gender = Console.ReadLine();
        Console.WriteLine("Enter the Address : ");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the Date of Birth : ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dateinput))
        {
            dateinput = dob;
        }
        Console.WriteLine("Enter the Contact number : ");
        contact_number = (long)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Register number : ");
        rollno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Grade : ");
        grade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Marks of three subjects : ");
        mark1 = Convert.ToInt32(Console.ReadLine());
        mark2 = Convert.ToInt32(Console.ReadLine());
        mark3 = Convert.ToInt32(Console.ReadLine());
        int age = Person.CalculateAge(dob);
        Console.WriteLine("Age:" + age);
        total = mark1 + mark2 + mark3;
        average = total / 3;
        if (mark1 > 40 && mark2 > 40 && mark3 > 40)
        {
            result = "Pass";
        }
        else
        {
            result = "Fail";
        }
    }

    public override void display()
    {
        Console.WriteLine("Person Name : " + name);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Address : " + address);
        Console.WriteLine("Date Of Birth : " + dob);
        Console.WriteLine("Contact Number : " + contact_number);
        Console.WriteLine("Roll no : " + rollno);
        Console.WriteLine("Grade : " + grade);
        Console.WriteLine("Mark 1 : " + mark1);
        Console.WriteLine("Mark 2 : " + mark2);
        Console.WriteLine("Mark 3 : " + mark3);
        Console.WriteLine("Total : " + total);
        Console.WriteLine("Average : " + average);
        Console.WriteLine("Result : " + result);
     
    }
}
public class Sample
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.accept();
        s1.display();
    }
}

