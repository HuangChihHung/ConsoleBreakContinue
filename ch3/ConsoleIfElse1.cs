﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class ConsoleIfElse1
    {
        public static void consoleIfElse1()
        {
            int age;
            Console.Write("請輸入年齡 : ");
            age = int.Parse(Console.ReadLine());
            if (age >= 10 && age <= 19)
                Console.WriteLine("你的年齡是 {0} , 是青少年", age);
            else
                Console.WriteLine("你的年齡是 {0} , 不是青少年", age);
            Console.Read();
        }
     }
}

