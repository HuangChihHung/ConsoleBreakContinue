using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4512
    {
        public static void cC4512()
        {
            String[] name = new String[4] {"周華健", "蔡依林", "張學友", "劉德華" };
            int[,] vote = new int[4, 3] { { 650, 478, 111 }, { 14, 23, 58 }, { 500, 700, 65 }, { 124, 58, 666 } };

            int[] total_P = new int[4] { 0,0,0,0} ;
            int total_All = 0;

            Console.WriteLine();
            Console.WriteLine("  姓名\t第一區\t第二區\t第三區\t總票數");
            Console.WriteLine("=========================================");

            for (int i = 0; i <= vote.GetUpperBound(0); i++) //0~3
            {

                Console.Write("  {0}  ", name[i]);

                for (int j = 0; j <= vote.GetUpperBound(1); j++) //0~2
                {
                    total_P[i] += vote[i,j];
                    Console.Write("{0}\t", vote[i, j]);

                }
                total_All += total_P[i];

                Console.WriteLine("{0}", total_P[i]);
            }
            Console.WriteLine();
            
            for (int i = 0; i <= total_P.GetUpperBound(0); i++) //0~3
            {
                Console.WriteLine("  {0}  得票率 : {1}%", name[i], (total_P[i] *100)/ total_All);
            }
            

            Console.Read();

        }
    }
}