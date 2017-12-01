using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class C4527_1
    {
        public static void c4527_1()
        {
            string[] name = new string[] { "小明", "小王", "小呆", "小華", "張三", "李四" };
            int[] score = new int[] { 89, 74, 100, 32, 99, 11 };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("第 " + (i + 1) + " 位學生" + name[i] + "的成績是" + score[i]);

            }

            Console.WriteLine();
            Console.Write("請輸入欲查詢的學生：");

            string searchName = Console.ReadLine();
            int searchIndex = SearchData(ref name, searchName);
            if (searchIndex == -1)
            {
                Console.WriteLine("找不到該位學生");
            }
            else
            {
                Console.WriteLine("找到了,第 " + (searchIndex + 1) + " 位學生" + name[searchIndex] + "的成績是" + score[searchIndex]);
            }

            Console.ReadLine();
        }

        static int SearchData(ref string[] a, string s)
        {
            int searchIndex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                {
                    searchIndex = i;
                    break;
                }
            }
            return searchIndex;
        }
    }

}