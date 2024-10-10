using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.盛最多水的容器
{
    internal class Program
    {

        /*
         给定一个长度为 n 的整数数组 height 。有 n 条垂线，第 i 条线的两个端点是 (i, 0) 和 (i, height[i]) 。

        找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。

        返回容器可以储存的最大水量。

        说明：你不能倾斜容器。
        输入：[1,8,6,2,5,4,8,3,7]
        输出：49 
        解释：图中垂直线代表输入数组 [1,8,6,2,5,4,8,3,7]。在此情况下，容器能够容纳水（表示为蓝色部分）的最大值为 49。
        示例 2：

        输入：height = [1,1]
        输出：1
         */
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Solution solution = new Solution();
            int value = solution.MaxArea(arr);
            Console.WriteLine(value);
            Console.ReadLine();

        }
    }

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int head = 0;
            int tail = height.Length - 1;
            int area = 0;
            while (head < tail)
            {
                int temp;
                if (height[head] > height[tail])
                {
                    temp = height[tail] * (tail - head);
                    tail--;
                }
                else
                {
                    temp = height[head] * (tail - head);
                    head++;
                }
                area = temp > area ? temp : area;
            }
            return area;
        }
    }
}
