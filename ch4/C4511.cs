using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class CC4511
    {

        private static int getMax_2(int v1, int v2)
        {

            if (v1 >= v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
            
        }


        private static int getMax_3(int v1, int v2, int v3)
        {

            if ((v1 >= v2) && (v1 >= v3))
            {
                return v1;
            }
            else if ((v2 >= v1) && (v2 >= v3))
            {
                return v2;
            }
            else
            {
                return v3;
            }
            
        }

        private static int getMax_Arr(int[] arr)
        {

            int[] arr1 = arr;
            Array.Sort(arr1);
            return arr1[arr1.GetUpperBound(0)];
        }


        public static void cC4511()
        {

            int[] M = { 50, 95,168, 125, 6 };

            Console.WriteLine("95 和69 最大數為{0}", getMax_2(95,69));

            Console.WriteLine("80 95  76最大數為{0}", getMax_3(80, 95,76));

            Console.WriteLine("n [50 ,95.168,125,6]{0}", getMax_Arr(M));

            Console.ReadLine();


        }
        
    }
}