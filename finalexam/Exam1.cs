using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam1
    {

        public static void exam1()
        {

            Console.WriteLine("排序前數列: ");

            for (int i = 0; i < Program.len; i++)
            {
                Console.Write("{0} ", Program.arr_int[i]);
            }

            Console.WriteLine();


            for (int i = 0; i < Program.len - 1; i++) //0- 10
            {

                for (int j = 0; j < Program.len - 1 - i; j++)//  
                {

                    if (Program.arr_int[j] >= Program.arr_int[j + 1])
                    {
                        int temp = Program.arr_int[j];
                        Program.arr_int[j] = Program.arr_int[j + 1];
                        Program.arr_int[j + 1] = temp;
                    }

                }
                
            }

            Console.WriteLine("排序後數列: ");

            for (int i = 0; i < Program.len; i++)
            {
                Console.Write("{0} ", Program.arr_int[i]);
            }

            Console.WriteLine();
            
            Console.Read();
        }
        
    }
}