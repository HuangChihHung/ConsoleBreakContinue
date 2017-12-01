using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4514
    {
        public static void cC4514()
        {
            int[] input = new int[10];


            Console.WriteLine();
            Console.WriteLine("  請輸入 10個 整數 到陣列 : ");
            Console.WriteLine();

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                Console.Write("  請輸入 第 {0} 個 整數 : ",i+1);
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            
            Array.Sort(input);

            Console.WriteLine("  輸入資料由小而大做遞增排序 : ");

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                Console.Write("  {0},\t", input[i]);
            }

            Console.WriteLine();
            Console.Read();

        }
    }
}