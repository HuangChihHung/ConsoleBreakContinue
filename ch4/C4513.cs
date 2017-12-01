using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4513
    {
        public static void cC4513()
        {
            int[] input = new int[5];


            Console.WriteLine();
            Console.WriteLine("  請輸入五個整數 : ");
            Console.WriteLine();

            for (int i = 0; i <= input.GetUpperBound(0); i++)
            {
                Console.Write("  輸入 第{0}個 整數 : ",i+1);
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            Array.Sort(input);

            Console.WriteLine("  最小數 : {0}", input[input.GetLowerBound(0)]);
            Console.WriteLine("  最大數 : {0}", input[input.GetUpperBound(0)]);

            Console.Read();

        }
    }
}