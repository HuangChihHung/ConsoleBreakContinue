using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4527
    {
        public static void cC4527()
        {

           

            string[] name = new string[6] {"小明","小王","小呆","小華","王五","張三"};
            int[] score = new int[6] {0,0,0,0,0,0};
            string sname;
            int sresult;


            for (int i = 0; i <= name.GetUpperBound(0); i++)
            {
                Console.Write(" 第 {0} 位 學生{1}的成績是 : ",i+1,name[i]);

                score[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("  請輸入欲查詢的學生姓名 : ");
            sname = Console.ReadLine();

            // sresult =  Array.IndexOf(name, sname);

            sresult = cC4527_1(name, sname);

            Console.WriteLine();


            if (sresult != -1)
            {
                Console.WriteLine("  找到了 , 第 {0} 位 學生 {1} 的成績是 : {2}", sresult + 1, name[sresult],score[sresult]);
            }
            else
            {
                Console.WriteLine("  沒找到");
            }

            Console.ReadLine();
            
        }

        public static int cC4527_1(string[] cC4527_1_sar, string cC4527_1_s)
        {
            int returnV = -1;

            for (int i = 0; i <= cC4527_1_sar.GetUpperBound(0); i++)
            {
                if (cC4527_1_s.Equals(cC4527_1_sar[i]))
                {
                    returnV = i;

                    break;
                }

            }

            return returnV;

         }

    }
}