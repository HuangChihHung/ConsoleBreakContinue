using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4526
    {
        public static void cC4526()
        {

            int num;
            bool[] a_result;
            bool result;
            

            Console.WriteLine();
            Console.WriteLine("  求質數 , 請輸入一個兩位整數 : ");

            num = int.Parse(Console.ReadLine());

            a_result = new bool[num + 1];
            
            
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 2; i <= num; i++) //99
            {
                result = true;

                for (int j = 2; j < i; j++)
                {
                    if (i == 2)
                    {
                        break;
                    }

                    if ((i % j) == 0) 
                    {
                        result = false;
                        break;
                    }
                }

                if (result == true)
                {
                    a_result[i] = true;
                }
                
            }

           

            Console.WriteLine("  1 - {0} 的質數 如下 : ", num);
            Console.WriteLine("");

            for (int i = 2; i <= a_result.GetUpperBound(0); i++)
            {
                if (a_result[i] == true)
                {
                    Console.Write("  {0},\t",i);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.ReadLine();
            
        }
    }
}