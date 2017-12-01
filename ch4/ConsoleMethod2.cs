using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class ConsoleMethod2
    {
        // 定義GetWelcome方法，該方法傳回型別為string 字串
        private static string GetWelcome(string username, bool ismale)
        {
            string str = "";
            if (ismale)
            {
                str = username + "先生，歡迎光臨！";
            }
            else
            {
                str = username + "小姐，歡迎光臨！";
            }
            return str;
        }

        public static void consoleMethod2()
        {
            string name = "Jack Wu";
            //將方法傳回的結果指定給Welcome變數
            string Welcome = GetWelcome(name, true);
            Console.WriteLine(Welcome);
            Console.WriteLine();
            Console.WriteLine(GetWelcome("Mary Lin", false));
            Console.Read();
        }
    }
}
