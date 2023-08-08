using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace Task_0708
{
    //program-5
    class Debugging_2
    {
        static int num = 1;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            nc1 += new NumberChanger(MultNum);
            nc1(4);
            //calling the methods using the delegate object
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadLine();
        }
    }
}
