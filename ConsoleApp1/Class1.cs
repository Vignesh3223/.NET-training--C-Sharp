using System;
public class Person
{
    public string name;
    public string gender;
    public string address;
    public string dob;
    public int contact_number;
    public Person(string n, string g, string a, string db, int cn)
    {
        name = n;
        gender = g;
        address = a;
        dob = db;
        contact_number = cn;
    }
    public void accept() { }
    public virtual void display()
    {
        Console.WriteLine("Person Name : " + name);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Address : " + address);
        Console.WriteLine("Contact Number : " + contact_number);
    }
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
    public Student(string n, string g, string a, string db, int cn, int r, int gr, float m1, float m2, float m3, float t, float av, string res) :
    base(n, g, a, cn, db)
    {
        rollno = r;
        grade = gr;
        mark1 = m1;
        mark2 = m2;
        mark3 = m3;
        total = t;
        average = av;
        result = res;
    }
    public void accept()
    {
        total = m1 + m2 + m3;
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
        Console.WriteLine("Roll no : " + name);
        Console.WriteLine("Grade : " + grade);
        Console.WriteLine("Mark 1 : " + mark1);
        Console.WriteLine("Mark 2 : " + mark2);
        Console.WriteLine("Mark 3 : " + mark3);
        Console.WriteLine("Total : " + total);
        Console.WriteLine("Average : " + average);
        Console.WriteLine("Result : " + result);
    }
}
public class Test
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Raju";
        s1.gender = "Male";
        s1.address = "4B,Nana Nani,Vadavalli";
        S1.contact_number = 9952410378;
        s1.rollno = 101;
        s1.grade = 5;
        s1.mark1 = 45;
        s1.mark2 = 55;
        s1.mark3 = 60;
        s1.accept();
        s1.display();
    }
}
