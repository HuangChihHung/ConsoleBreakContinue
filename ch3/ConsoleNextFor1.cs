using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class ConsoleNextFor1
    {
         public static void consoleNextFor1()
        {
            // 設定 i為外層迴圈的初值， k為內層迴圈的初值
            for (int i = 1; i <= 5; i++)        // 外層迴圈
            {
                for (int k = 1; k <= i; k++)    // 內層迴圈
                    Console.Write("  {0}", k); // 游標停在同一列
                Console.WriteLine();          // 強迫換列
            }
            Console.Read();
        }
    }
}
