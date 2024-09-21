using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _367.有效的完全平方数
{
    internal class Program
    {
        /*
             给你一个正整数 num 。如果 num 是一个完全平方数，则返回 true ，否则返回 false 。

            完全平方数 是一个可以写成某个整数的平方的整数。换句话说，它可以写成某个整数和自身的乘积。

            不能使用任何内置的库函数，如  sqrt 。



            示例 1：

            输入：num = 16
            输出：true
            解释：返回 true ，因为 4 * 4 = 16 且 4 是一个整数。
            示例 2：

            输入：num = 14
            输出：false
            解释：返回 false ，因为 3.742 * 3.742 = 14 但 3.742 不是一个整数。*/
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool flag = solution.IsPerfectSquare(16);
            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 0)
            {
                return false;
            }
            else if (num == 1)
            {
                return true;
            }

            int left = 0;
            int right = num;
            int mid;
            while (left + 1 != right)
            {
                mid = (left + right) / 2;
                if ((long)mid * mid > num)
                {
                    right = mid;
                }
                else if ((long)mid * mid < num)
                {
                    left = mid;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
