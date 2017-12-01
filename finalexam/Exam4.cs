using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam4
    {

        public static void exam4()
        {
            char tmpe;

            Console.Write("請輸入要產生聖誕樹的字元符號? ");
            tmpe = char.Parse(Console.ReadLine());
            //Console.WriteLine("{0}", tmpe);

            int line = 10;

            for (int i = 1; i <= line; i++)
            {

                for (int j = 1; j <= line - i; j++)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", tmpe);

                }
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("{0}", tmpe);

                }
                Console.WriteLine();


            }



            Console.Read();
        }
        
    }
}