using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Params
    {
        static void Main(string[] args)
        {
           
            Params paramArray = new Params();
            object[] trainee = new object[6];
            Console.WriteLine("DOTNET Trainees Information");
            Console.WriteLine("\n");
            paramArray.Display("Arun Joseph", 20, 9345524351, "Gudalur");
            Console.WriteLine("\n");
            paramArray.Display("Hemanth", 20, 9325824601, "Coimbatore");
            Console.WriteLine("\n");
            paramArray.Display("Haritha", 20, 9360565351, "Coimbatore");
            Console.WriteLine("\n");
            paramArray.Display("Siva Bharat", 20, 9347888024, "Kanyakumari");
            Console.WriteLine("\n");
            paramArray.Display("Srikanth", 20, 9004522147, "Coimbatore");
            Console.WriteLine("\n");
            paramArray.Display("Sharon", 20, 9791920057, "Coimbatore");
            Console.WriteLine("\n");
            paramArray.Display("Vignesh", 20, 6369754180, "Coimbatore");
            Console.WriteLine("\n");
            paramArray.Display("Yamini Priya", 20, 7874550712, "Coimbatore");
            Console.ReadLine();
        }
        public void Display(params object[] trainees)
        {
            for(int i=0; i<trainees.Length;i++)
            {
                Console.WriteLine(trainees[i]);
            }
        }
    }
}
