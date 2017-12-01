using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam10
    {

        public static void exam10()
        {

            string M_temp = "";
            string M_temp_1 = "";

            int M_A = 0;
            int M_E = 0;
            int M_I = 0;
            int M_O = 0;
            int M_U = 0;
                
            Console.WriteLine("請輸入一個字串");
            M_temp =  Console.ReadLine();


            for (int i = 0; i < M_temp.Length; i++)
            {
                M_temp_1 = M_temp.Substring(i, 1);

                if (M_temp_1 == "a")
                {
                    M_A++;
                }
                if (M_temp_1 == "e")
                {
                    M_E++;
                }
                if (M_temp_1 == "i")
                {
                    M_I++;
                }
                if (M_temp_1 == "o")
                {
                    M_O++;
                }
                if (M_temp_1 == "u")
                {
                    M_U++;
                }
            }


            Console.WriteLine("出現a的次數是 " + M_A);
            Console.WriteLine();

            Console.WriteLine("出現e的次數是 " + M_E);
            Console.WriteLine();

            Console.WriteLine("出現i的次數是 " + M_I);
            Console.WriteLine();

            Console.WriteLine("出現o的次數是 " + M_O);
            Console.WriteLine();

            Console.WriteLine("出現u的次數是 " + M_U);
            Console.WriteLine();

            Console.ReadLine();



        }

    }
}