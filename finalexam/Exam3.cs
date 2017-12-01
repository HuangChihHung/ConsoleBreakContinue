using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam3
    {

        public static void exam3()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {

                    Console.Write("{0} * {1} = {2}\t", i, j, i * j);

                }

                Console.WriteLine();

            }

            Console.Read();
            
        }
        
    }
}