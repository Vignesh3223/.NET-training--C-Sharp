using System;
using System.Data;

public class Person
{
    public string name;
    public string gender;
    public string address;
    public string dob;
    public long contact_number;
    public Person(string n, string gen, string addr, string db, long cn)
    {
        name = n;
        gender = gen;
        address = addr;
        dob = db;
        contact_number = cn;
    }   public virtual void display()
    {
        Console.WriteLine("Person Name : " + name);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Address : " + address);
        Console.WriteLine("Date Of Birth : " + dob);
        Console.WriteLine("Contact Number : " + contact_number);
    }
    public void accept() { }
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
    public Student(string n, string gen, string addr, string db, long cn) :base(n, gen, addr, db, cn)
    { }
    public new void accept()
    {
        Console.WriteLine("Enter the Register number : ");
        rollno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Grade : ");
        grade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Marks of three subjects : ");
        mark1 = Convert.ToInt32(Console.ReadLine());
        mark2 = Convert.ToInt32(Console.ReadLine());
        mark3 = Convert.ToInt32(Console.ReadLine());
        total = mark1 + mark2 + mark3;
        average = total / 3;
        if (average > 40)
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
        base.display();
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
class Test
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Raju", "Male", "4B,Nana Nani,Vadavalli", "22/04/2004", 9952410378);
        s1.accept();
        s1.display();
    }
}
