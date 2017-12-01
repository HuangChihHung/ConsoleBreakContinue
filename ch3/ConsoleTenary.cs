using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class ConsoleTenary
    {
         public static void consoleTenary()
        {
                //、taxRate稅率變數為浮點數型別
                double netIncome;  //宣告income淨所得變數為浮點數型別
                int taxRate;       // 宣告taxRate稅率變數為整數型別
            
                Console.Write("請輸入全年綜合所得淨額(元) : ");
                netIncome = double.Parse(Console.ReadLine());
            
                if (netIncome > 0)   // 檢查 淨所得是否大於零
                     {
                          taxRate = (netIncome <= 500000 ? 5 : (netIncome <= 1130000 ? 12 : (netIncome <= 2260000 ? 20 : 
                                           (netIncome <= 4230000 ? 30 : 40))));
                          Console.WriteLine("\n === {0} 元的所得稅率為 {1}% .", netIncome, taxRate);
                       }
                else
                        Console.WriteLine("\n === 全年所得淨額為負 ! 不用繳稅 ... ");
            
                Console.Read();
        }
    }
}
