using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            

            bool flag = true;
            while (flag)
            {
               

                string input = "";
                Console.WriteLine("1.  ConsoleEnum1 ");
                Console.WriteLine("2.  ConsoleEscSeq ");
                Console.WriteLine("3.  ConsoleEx1 ");
                Console.WriteLine("4.  ConsoleFormat ");
                Console.WriteLine("5.  ConsoleShift ");
                Console.WriteLine("6.  ConsoleStruct1");
                Console.WriteLine("7.  ConsoleToString");
                Console.WriteLine("8.  MyFirst ");
                Console.WriteLine("------------------------");
                Console.WriteLine("請輸入要執行的範例");

                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;

                        break;

                    case "1":
                        ConsoleEnum1.consoleEnum1();

                        break;
                    case "2":
                        ConsoleEscSeq.consoleEscSeq();
                        break;
                    case "3":
                        ConsoleEx1.consoleEx1();
                        break;
                    case "4":
                        ConsoleFormat.consoleFormat();
                        break;
                    case "5":
                        ConsoleShift.consoleShift();
                        break;
                    case "6":
                        ConsoleStruct1.consoleStruct1();
                        break;
                    case "7":
                        ConsoleToString.consoleToString();
                        break;
                    case "8":
                        MyFirst.myFirst();
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
