using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class ConsoleBreakContinue
    {
        public static void consoleBreakContinue()
        {
            int sum, upper, n; //sum 為連加的總和, upper為上限值, n為連加的終值 
            sum = 0; n = 0;
            Console.Write("\n ==  求 1 + 2 + 3 + ... + N  的總和 小於等於 SUM   ===");
            Console.Write("\n\n  請輸入 SUM 值 ( 電腦 算出 終值 N)  : ");

            upper = int.Parse(Console.ReadLine()); // 輸入值轉整數再指定給upper
            do
            {
                n += 1;            // 連加增值為1
                if (sum <= upper)  // 判斷 sum總和是否小於等於輸入的上限值upper                    
                {
                    sum += n;
                    continue; // 跳到do…while 處判斷n是否大於0
                }
                else   // sum值大於上限值upper時,執行else敘述區段
                {
                    sum -= n - 1;
                    break;        // 離開迴圈
                }
            } while (n > 0);   // 若n>0則進入迴圈

            Console.WriteLine("\n  終值 N =  {0}  ,  加總上限值 SUM = {1} ", n - 2, upper);
            Console.WriteLine("\n  結果 : 1 + 2... + {0}  = {1}", n - 2, sum);

            Console.Read();
        }
    }
}
