using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Task_0908.CustomDeveloperAttribute;

namespace Task_0908
{
    class CustomDeveloperAttribute
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor |
            AttributeTargets.Field | AttributeTargets.Method |
            AttributeTargets.Property, AllowMultiple = true)]

        public class DeveloperAttribute : Attribute
        {
            public int id;
            public string name;
            public string status;
            public DeveloperAttribute(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public int ID
            {
                get
                {
                    return id;
                }
            }
            public String NAME
            {
                get
                {
                    return name;
                }
            }
            public string STATUS
            {
                get
                {
                    return status;
                }
            }
            public static void AttributesDisplay(Type classType)
            {
                Console.WriteLine("Information inside the class {0} are \n", classType.Name);
                foreach (object attribute in classType.GetCustomAttributes(false))
                {
                    DeveloperAttribute dev = (DeveloperAttribute)attribute;
                    if (null != dev)
                    {
                        Console.WriteLine("Employee ID: {0}", dev.id);
                        Console.WriteLine("Employee Name: {0}", dev.name);
                        Console.WriteLine("Task Status: {0}", dev.status);
                        Console.WriteLine("--------------");
                    }
                }
                foreach (_MethodInfo method in classType.GetMethods())
                {
                    object[] metharr = method.GetCustomAttributes(true);
                    foreach (Attribute attribute in metharr)
                    {
                        if (attribute is DeveloperAttribute developer)
                        {
                            List<string> names = new List<string>();
                            DeveloperAttribute dev = (DeveloperAttribute)attribute;
                            if (null != dev && !names.Contains(method.Name))
                            {
                                names.Add(method.Name);
                                Console.WriteLine("Employee ID: {0} for Method {1}", dev.id, method.Name);
                                Console.WriteLine("Employee Name: {0}", dev.name);
                                Console.WriteLine("Task Status: {0}", dev.status);
                                Console.WriteLine("--------------");
                            }
                        }
                    }
                }
                foreach (_ConstructorInfo con in classType.GetConstructors())
                {
                    object[] consarr = con.GetCustomAttributes(true);
                    foreach (Attribute attribute in consarr)
                    {
                        if (attribute is DeveloperAttribute developer)
                        {
                            List<string> names = new List<string>();
                            DeveloperAttribute dev = (DeveloperAttribute)attribute;
                            if (null != dev && !names.Contains(con.Name))
                            {
                                names.Add(con.Name);
                                Console.WriteLine("Employee ID: {0} for Method {1}", dev.id, con.Name);
                                Console.WriteLine("Employee Name: {0}", dev.name);
                                Console.WriteLine("Task Status: {0}", dev.status);
                                Console.WriteLine("--------------");
                            }
                        }
                    }
                }
                foreach (_PropertyInfo prop in classType.GetProperties())
                {
                    object[] proparr = prop.GetCustomAttributes(true);
                    foreach (Attribute attribute in proparr)
                    {
                        if (attribute is DeveloperAttribute developer)
                        {
                            List<string> names = new List<string>();
                            DeveloperAttribute dev = (DeveloperAttribute)attribute;
                            if (null != dev && !names.Contains(prop.Name))
                            {
                                names.Add(prop.Name);
                                Console.WriteLine("Employee ID: {0} for Method {1}", dev.id, prop.Name);
                                Console.WriteLine("Employee Name: {0}", dev.name);
                                Console.WriteLine("Task Status: {0}", dev.status);
                            }
                        }
                    }
                }

            }
        }
    }
    [Developer(101, "Ajay", status = "In Progress --> Class")]
    [Developer(102, "Cathy", status = "Completed --> Class")]
    public class Employee
    {
        [Developer(102, "Cathy", status = "Completed --> Property")]
        public int age { get; set; }

        [Developer(101, "Ajay", status = "In Progress --> Constructor")]
        public Employee(int age)
        {
            this.age = age;
        }

        [Developer(101, "Ajay", status = "In Progress --> Method1")]
        public void Display1()
        {
            Console.WriteLine("I am a Developer");
        }
        [Developer(102, "Cathy", status = "Completed --> Method2")]
        public void Display2()
        {
            Console.WriteLine("I am a Designer");
        }
    }

        public class Employee2
        {
            [Developer(102, "Cathy", status = "Completed --> Property")]
            public int age { get; set; }

            [Developer(101, "Ajay", status = "In Progress --> Constructor")]
            public Employee2(int age)
            {
                this.age = age;
            }

            [Developer(101, "Ajay", status = "In Progress --> Method1")]
            public void Display3()
            {
                Console.WriteLine("I am a Developer");
            }
            [Developer(102, "Cathy", status = "Completed --> Method2")]
            public void Display4()
            {
                Console.WriteLine("I am a Designer");
            }
        }
        internal class CustomAttribute
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Class methods");
            Console.WriteLine("--------------");
            DeveloperAttribute.AttributesDisplay(typeof(Employee));
            Console.WriteLine("\n######################\n");
            DeveloperAttribute.AttributesDisplay(typeof(Employee2));
            Console.ReadLine();
        }
    }
}
