using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
      class Class3
      {
           private static int age = 29;
           public static string name = "陳春嬌";
      }

      class ConsoleStaticVar
    {        
            private static int age = 25;
            private static string name = "王志明";
        public static void consoleStaticVar()
        {
            Console.WriteLine("ConsoleStaticVar類別靜態變數的資訊-->{0}的年齡為{1}歲\n",
            name, age.ToString());
            Console.WriteLine("Class3類別靜態變數的資訊-->{0}的年齡無法取得",
            Class3.name);
            Console.Read();
        }
    }
}
