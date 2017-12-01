using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
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
                Console.WriteLine("1.  EmptyClass ");
                //Console.WriteLine("2.  ConsoleForEach1 ");
                //Console.WriteLine("3.  ConsoleAryForEach2 ");
                //Console.WriteLine("4.  ConsoleSort1");
                //Console.WriteLine("5.  CC4512");
                //Console.WriteLine("6.  CC4513");
                //Console.WriteLine("7.  CC4514");
                //Console.WriteLine("8.  CC4525");
                //Console.WriteLine("9.  CC4526");
                //Console.WriteLine("10. CC4527");
                //Console.WriteLine("11. ReadArg");
                //Console.WriteLine("12. ConsoleAmount");
                //Console.WriteLine("13. ConsoleMethod1");
                //Console.WriteLine("14. ConsoleMethod2");
                //Console.WriteLine("15. ConsoleMethod3");
                //Console.WriteLine("16. ConsoleMethod4");
                //Console.WriteLine("17. CallValue");
                //Console.WriteLine("18. ConsoleByRef");
                //Console.WriteLine("19. ConsoleByOut");
                //Console.WriteLine("20. ConsoleGetMax");
                //Console.WriteLine("21. ConsoleOverLoads");
                //Console.WriteLine("22. ConsoleStaticVar");
                //Console.WriteLine("23.  CC4511");





                Console.WriteLine("------------------------");
                Console.WriteLine("請輸入要執行的範例");

                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;

                        break;

                    case "1":
                        EmptyClass.emptyClass();
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
