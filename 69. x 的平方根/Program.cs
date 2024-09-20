using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.x_的平方根
{
    internal class Program
    {

        /*
         给你一个非负整数 x ，计算并返回 x 的 算术平方根 。

        由于返回类型是整数，结果只保留 整数部分 ，小数部分将被 舍去 。

        注意：不允许使用任何内置指数函数和算符，例如 pow(x, 0.5) 或者 x ** 0.5 。



        示例 1：

        输入：x = 4
        输出：2
        示例 2：

        输入：x = 8
        输出：2
        解释：8 的算术平方根是 2.82842..., 由于返回类型是整数，小数部分将被舍去。
         */
        static void Main(string[] args)
        {
            Console.WriteLine();
            Solution solution = new Solution();
            int v = solution.MySqrt(2147395599);
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            if (x < 4) return 1;
            if (x == 4) return 2;
            int left = 0;
            int right = x/2;
            while (left + 1 != right)
            {
                int mid = (left + right) / 2;

                if ((long)mid * mid > x)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return left;
        }
    }
}
