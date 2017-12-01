using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam6
    {

        private static double f(double x)
        {
            double temp = 0;

            temp += 3 * x * x * x;
            temp += 2 * x;
            temp -= 1;
            
            return temp;
        }


        public static void exam6()
        {
            
            Console.WriteLine("f(-3.2)={0:f2}", f(-3.2));
            Console.WriteLine();
            Console.WriteLine("f(-2.1)={0:f2}", f(-2.1));
            Console.WriteLine();
            Console.WriteLine("f(0)={0:f2}", f(0));
            Console.WriteLine();
            Console.WriteLine("f(2.1)={0:f2}", f(2.1));
            Console.WriteLine();
            Console.ReadLine();
            
        }

    }
}