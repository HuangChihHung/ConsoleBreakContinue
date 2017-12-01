using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class ConsoleFor1
    {
        public static void consoleFor1()
        {
            string pwd = "";    // 存放密碼變數為字串型別
            int count = 0;      // 用來記錄輸入密碼的次數為整數型別

            for (count = 1; count <= 3; count++)
            {
                Console.Write("請輸入密碼  : ");
                pwd = Console.ReadLine(); // 等待由鍵盤輸入密碼置入pwd變數

                if (pwd == "lucky")   // 檢查密碼是否為ymca
                    break;           // 若正確離開 for 迴圈                
                else                   // 若密碼不正確執行下列提示訊息
                    Console.WriteLine("\nSorry! 密碼錯誤{0}次, 請重新輸入 ...", count);
                Console.WriteLine();
            }
            if (pwd == "lucky")  // 判斷pwd密碼是否等於 "ymca"
                Console.WriteLine("\n=== 登入成功, 歡迎進入本系統! ……"); //密碼正確
            else
                Console.WriteLine("\n=== 非法進入! ……"); // 密碼不正確執行此敘述
            Console.Read();
        }
    }
}
