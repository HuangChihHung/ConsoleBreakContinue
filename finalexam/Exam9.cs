using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam9
    {

        private static int mod(int x,int y)
        {
           
            return x % 5;
        }


        public static void exam9()
        {
            int M_temp;

            M_temp = mod(17, 5);


            Console.WriteLine("mod(17,5) = " + M_temp);

            Console.ReadLine();
            
        }

    }
}