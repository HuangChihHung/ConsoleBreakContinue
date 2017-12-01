using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Test
    {

        public static void test() {

            if (Program.len != 0)
            {

                for (int i = 0; i < Program.len; i++)
                {


                    Console.WriteLine(Program.arr[i]);
                }
            }
            else
            {
                Console.WriteLine("沒有任何引數!");

            }
            Console.Read();
        }    



    }
}
