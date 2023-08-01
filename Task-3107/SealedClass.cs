using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3107
{
    internal sealed class SealedClass
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
        public void Display()
        {
            Console.WriteLine("It is a Sealed Class");
        }
    }
    ////sealed class Animal
    ////{
    ////    public void eat()
    ////    {
    ////        Console.WriteLine("eating..");
    ////    }
    ////    public void bark()
    ////    {
    ////        Console.WriteLine("Barks..");
    ////    }
    ////}
    ////public class Dog : Animal
    ////{
    ////    public new void eat()
    ////    {
    ////        Console.WriteLine("eating biscuits..");
    ////    }
    ////    public new void sound()
    ////    {
    ////        Console.WriteLine("Barks Louder..");
    ////    }
    ////}
    class SealedClassDemo
    {
        static void Main(string[] args)
        {
            SealedClass sealedClass= new SealedClass();
            int total = sealedClass.Add(10, 7);
            Console.WriteLine("Sum is " + total);
            sealedClass.Display();
            //Dog dog = new Dog();
            //dog.eat();
            //dog.bark();
            Console.ReadLine();
        }
    }
}
