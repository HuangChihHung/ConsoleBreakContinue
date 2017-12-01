using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam7
    {

        public static void exam7()
        {

            Array.Sort(Program.arr);

            Console.WriteLine("12個陣列元素中("+"12,3,24,1,8,6,11,21,7,18,9,90"+")中最大數為 : {0}",Program.arr[Program.arr.GetUpperBound(0)]);

            Console.Read();
        }
        
    }
}