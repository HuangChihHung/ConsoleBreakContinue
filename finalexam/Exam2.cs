using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam2
    {

        public static void exam2()
        {
            int temp1 = 12;
            
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

            Console.Write("元素排序後: ");
          
            for (int i = 0; i < Program.len; i++)
            {
                Console.Write("{0} ", Program.arr_int[i]);
            }

            Console.WriteLine();

            Console.Write("請輸入要搜尋的數字:");
            temp1 = int.Parse(Console.ReadLine());


            Console.Write("元素位置 : ");

            Console.Write(Array.BinarySearch(Program.arr_int, temp1));
            

            Console.Read();
            
        }
        
    }
}