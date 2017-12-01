using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Program
    {
        static public int len;
        static public string[] arr;
        static void Main(string[] args)
        {

            len = args.Length;
            arr = new string[len];
            arr = args;

            bool flag = true;
            while (flag)
            {
                string input = "";
                Console.WriteLine("1.  ConsoleAry ");
                Console.WriteLine("2.  ConsoleForEach1 ");
                Console.WriteLine("3.  ConsoleAryForEach2 ");
                Console.WriteLine("4.  ConsoleSort1");
                Console.WriteLine("5.  CC4512");
                Console.WriteLine("6.  CC4513");
                Console.WriteLine("7.  CC4514");
                Console.WriteLine("8.  CC4525");
                Console.WriteLine("9.  CC4526");
                Console.WriteLine("10. CC4527");
                Console.WriteLine("11. ReadArg");
                Console.WriteLine("12. ConsoleAmount");
                Console.WriteLine("13. ConsoleMethod1"); 
                Console.WriteLine("14. ConsoleMethod2"); 
                Console.WriteLine("15. ConsoleMethod3"); 
                Console.WriteLine("16. ConsoleMethod4"); 
                Console.WriteLine("17. CallValue"); 
                Console.WriteLine("18. ConsoleByRef");
                Console.WriteLine("19. ConsoleByOut"); 
                Console.WriteLine("20. ConsoleGetMax");
                Console.WriteLine("21. ConsoleOverLoads");
                Console.WriteLine("22. ConsoleStaticVar");
                Console.WriteLine("23.  CC4511");





                Console.WriteLine("------------------------");
                Console.WriteLine("請輸入要執行的範例");

                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;

                        break;

                    case "1":
                        ConsoleAry.consoleAry();

                        break;
                    case "2":
                        ConsoleForEach1.consoleForEach1();
                        break;

                    case "3":
                        ConsoleAryForEach2.consoleAryForEach2();


                        break;
                    case "4":
                        ConsoleSort1.consoleSort1();
                        break;
                    case "5":

                        CC4512.cC4512();

                        break;
                    case "6":
                        CC4513.cC4513();

                        break;
                    case "7":
                        CC4514.cC4514();

                        break;
                    case "8":
                        CC4525.cC4525();
                        break;
                    case "9":
                        CC4526.cC4526();

                        break;
                    case "10":

                        CC4527.cC4527();

                        break;
                    case "11":

                        Test.test();

                        break;
                    case "12":
                        ConsoleAmount.consoleAmount();
                        break;

                    case "13":
                        ConsoleMethod1.consoleMethod1();
                        break;

                    case "14":
                        ConsoleMethod2.consoleMethod2();

                        break;
                    case "15":
                        ConsoleMethod3.consoleMethod3();

                        break;
                    case "16":
                        ConsoleMethod4.consoleMethod4();

                        break;

                    case "17":

                        CallValue.callValue();

                        break;

                    case "18":

                        ConsoleByRef.consoleByRef();

                        break;

                    case "19":
                        ConsoleByOut.consoleByOut();


                        break;

                    case "20":
                        ConsoleGetMax.consoleGetMax();

                        break;
                    case "21":
                        ConsoleOverLoads.consoleOverLoads();



                        break;


                    case "22":
                        ConsoleStaticVar.consoleStaticVar();



                        break;

                    case "23":
                        CC4511.cC4511();

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
