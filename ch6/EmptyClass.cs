using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    class EmptyClass
    {

        public static void emptyClass() {

            Console.WriteLine("建立一個 EmptyClass  物件");
            EmptyClass A;
            A = new EmptyClass();
            Console.WriteLine("A 物件建立完成");
            Console.WriteLine("請按 Enter 結束");
            
            Console.Read();
        }

    }
}
