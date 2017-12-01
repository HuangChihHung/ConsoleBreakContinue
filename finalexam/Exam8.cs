using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalexam
{
    class Exam8
    {

        public static void exam8()
        {
            //int[,,] A ={{ 2 },{ 3 },{ 4} };

            int M_Temp = 0;

            int[,,] A_1 = new int[2, 3, 4];

            A_1[0, 0, 0] = 1; A_1[0, 0, 1] = 2; A_1[0, 0, 2] = 3; A_1[0, 0, 3] = 4;
            A_1[0, 1, 0] = 5; A_1[0, 1, 1] = 6; A_1[0, 1, 2] = 7; A_1[0, 1, 3] = 8;
            A_1[0, 2, 0] = 9; A_1[0, 2, 1] = 10; A_1[0, 2, 2] = 11; A_1[0, 2, 3] = 12;

            A_1[1, 0, 0] = 13; A_1[1, 0, 1] = 14; A_1[1, 0, 2] = 15; A_1[1, 0, 3] = 16;
            A_1[1, 1, 0] = 17; A_1[1, 1, 1] = 18; A_1[1, 1, 2] = 19; A_1[1, 1, 3] = 20;
            A_1[1, 2, 0] = 21; A_1[1, 2, 1] = 22; A_1[1, 2, 2] = 23; A_1[1, 2, 3] = 24;



            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        M_Temp += A_1[i, j, k];

                    }

                }

            }

            Console.WriteLine("sum="+ M_Temp);
            Console.ReadLine();




        }

    }
        
    
}