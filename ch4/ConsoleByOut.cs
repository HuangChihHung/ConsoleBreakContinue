using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class ConsoleByOut
    {
        private static void CallOut(out int x, out int y)
        {
            int z;
            x = 20;
            y = 30;
            Console.WriteLine("\n方法內 交換前\t\t\t：x= {0}   y={1} ", x, y);
            z = x;   //透過第三個變數來做x,y值作互換
            x = y;
            y = z;
            Console.WriteLine("\n方法內 交換後\t\t\t：x= {0}   y={1}", x, y);
        }

        public static void consoleByOut()
        {
            Console.WriteLine("\n  **** Call By Value 傳值呼叫 **** \n");
            int a, b;
            Console.WriteLine("\n呼叫敘述 未進入方法前 , a 和 b 值不須設定");
            CallOut(out a, out b);
            Console.WriteLine("\n呼叫敘述 離開方法回原處時\t：a={0}    b={1}", a, b);
            Console.Read();
        }
    }
}
