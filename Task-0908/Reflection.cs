using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_0908
{
    class AttributeDemo1 : Attribute
    {
        private string name;
        private string city;

        public AttributeDemo1(string name,string city)
        {
            this.name = name;
            this.city = city;
        }
        public static void Display(Type classType)
        {
            Console.WriteLine("All the methods inside the class {0} are ", classType.Name);
            MethodInfo[] methods = classType.GetMethods();
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] attrarray = methods[i].GetCustomAttributes(true);
                foreach (Attribute item in attrarray)
                {
                    if (item is AttributeDemo1)
                    {
                        AttributeDemo1 attrobj = (AttributeDemo1)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name, attrobj.name, attrobj.city);
                    }
                }
            }
        }
    }
    class Trainer
    {
        int id;
        string name;
        int age;
        string city;

        public Trainer(int id, string name, int age, string city)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.city = city;
        }
        [AttributeDemo1("Accessor Values", "Generates Trainee ID")]
        public int getID()
        {
            return id;
        }
        [AttributeDemo1("Accessor Values", "Generates Trainee Name")]
        public string getName()
        {
            return name;
        }
        [AttributeDemo1("Accessor Values", "Generates Trainee Age")]
        public int getAge()
        {
            return age;
        }
        [AttributeDemo1("Accessor Values", "Generates Trainee City")]
        public string getCity()
        {
            return city;
        }
    }
    class Trainee
    {
        int id;
        string name;
        int age;
        string city;

        public Trainee(int id, string name, int age, string city)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.city = city;
        }
        [AttributeDemo1("Values" , "Displays Trainee ID")]
        public int getID()
        {
            return id;
        }
        [AttributeDemo1("Values", "Displays Trainee Name")]
        public string getName()
        {
            return name;
        }
        [AttributeDemo1("Values", "Displays Trainee Age")]
        public int getAge()
        {
            return age;
        }
        [AttributeDemo1("Values", "Displays Trainee City")]
        public string getCity()
        {
            return city;
        }
    }
    internal class Reflection
    {
        static void Main(string[] args)
        {
            int a= 10;
            string name = "Jackie";
            char c = 'D';
            double d = 12378389232;
            float f = 13.06F;
            bool s = false;
            int[] arr = { 10, 20, 30, 40 };
            Type type1 = a.GetType();
            Type type2 = name.GetType();
            Type type3 = c.GetType();
            Type type4 = d.GetType();
            Type type5 = f.GetType(); 
            Type type6 = s.GetType();
            Type type7 = arr.GetType();
            Console.WriteLine("Type of a : " + type1.FullName);
            Console.WriteLine("Type of name : " + type2.FullName);
            Console.WriteLine("Type of c : " + type3.FullName);
            Console.WriteLine("Type of d : " + type4.FullName);
            Console.WriteLine("Type of f : " + type5.FullName);
            Console.WriteLine("Type of s : " + type6.FullName);
            Console.WriteLine("Type of arr : " + type7.FullName);
            Console.WriteLine("****************");
            Console.WriteLine("Math Class methods");
            Console.WriteLine("--------------");
            Console.WriteLine("All the methods inside the Math class are ");
            Type tp = typeof(Math);
            MethodInfo[] mathmethods = tp.GetMethods();
            List<string> names = new List<string>();
            foreach (MethodInfo mi in mathmethods)
            {
                if (!names.Contains(mi.Name))
                {
                    names.Add(mi.Name);
                    Console.WriteLine("Method Name : {0}", mi.Name);
                }
            }
            Console.WriteLine("****************");
            Console.WriteLine("Current Class methods");
            Console.WriteLine("--------------");
            AttributeDemo1.Display(typeof(Trainer));
            Console.WriteLine("--------------");
            AttributeDemo1.Display(typeof(Trainee));
            Console.WriteLine("****************");
            Console.ReadLine();
        }
    }
}
