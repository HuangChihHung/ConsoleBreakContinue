using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam5
    {


        private static int product(int n)
        {

            int temp = 1;

            for (int i = 1; i <= n; i++)
            {
                temp = temp * i;
            }
           
            return temp;
        }
    

        public static void exam5()
        {
            int M_temp;
            int M_temp1;

            Console.Write("輸入 n 的值?");


            M_temp = int.Parse(Console.ReadLine());

            M_temp1 = product(M_temp);
            
            Console.WriteLine("{0}! 的值 = {1}", M_temp, M_temp1);

            Console.ReadLine();

        }
        
    }
}