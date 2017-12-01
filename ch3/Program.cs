using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Program
    {

        static void Main(string[] args)
        {



            bool flag = true;
            while (flag)
            {


                string input = "";
                Console.WriteLine("1.  ConsoleBreakContinue");
                Console.WriteLine("2.  ConsoleDoWhile");
                Console.WriteLine("3.  ConsoleFor1");
                Console.WriteLine("4.  ConsoleGuessNo");
                Console.WriteLine("5.  ConsoleIfElse1");
                Console.WriteLine("6.  ConsoleIfElse2");
                Console.WriteLine("7.  ConsoleifElse3");
                Console.WriteLine("8.  ConsoleNextFor1");
                Console.WriteLine("9.  ConsoleNum");
                Console.WriteLine("10.  ConsoleSwitch1");
                Console.WriteLine("11.  ConsoleTenary");
                Console.WriteLine("12.  ConsoleTest");
                Console.WriteLine("13.  ConsoleWhile1");
                Console.WriteLine("------------------------");
                Console.WriteLine("請輸入要執行的範例");
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;

                        break;

                    case "1":
                        ConsoleBreakContinue.consoleBreakContinue();

                        break;
                    case "2":
                        ConsoleDoWhile.consoleDoWhile();
                        break;
                    case "3":
                        ConsoleFor1.consoleFor1();
                        break;
                    case "4":
                        ConsoleGuessNo.consoleGuessNo();
                        break;
                    case "5":
                        ConsoleIfElse1.consoleIfElse1();
                        break;
                    case "6":
                        ConsoleIfElse2.consoleIfElse2();
                        break;
                    case "7":
                        ConsoleifElse3.consoleifElse3();
                        break;
                    case "8":
                        ConsoleNextFor1.consoleNextFor1();
                        break;
                    case "9":
                        ConsoleNum.consoleNum();
                        break;
                    case "10":
                        ConsoleSwitch1.consoleSwitch1();
                        break;
                    case "11":
                        ConsoleTenary.consoleTenary();
                        break;
                    case "12":
                        ConsoleTest.consoleTest();
                        break;
                    case "13":
                        ConsoleWhile1.consoleWhile1();
                        break;

                    default:

                        //flag = false;

                        break;




                }

                Console.Clear();

            }


        }
    }
}
