using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_Extension_Method
{
    public class MyUtils
    {
        // cài đặt tính tổng từ 1 tới n vào kiểu INT của microsoft 
        public static int TongTu1toin(this int n)
        {
            int sum = 0;
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
            }
            return sum;

        }
        public static void  SapXepTangDan (this int[] ar)
        {
            for (int i = 1; i <= ar.Length; i ++)
            {

            }
        }

        public static void  xuatmang (this int[] arr)
        {
            foreach(int i in arr)
            {

            }
        }
    }
}
