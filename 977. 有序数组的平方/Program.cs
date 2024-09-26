using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977.有序数组的平方
{
    internal class Program
    {
        /*
         给你一个按 非递减顺序 排序的整数数组 nums，返回 每个数字的平方 组成的新数组，要求也按 非递减顺序 排序。
        
         示例 1：

            输入：nums = [-4,-1,0,3,10]
            输出：[0,1,9,16,100]
            解释：平方后，数组变为 [16,1,0,9,100]
            排序后，数组变为 [0,1,9,16,100]
            示例 2：

            输入：nums = [-7,-3,2,3,11]
            输出：[4,9,9,49,121]
         */
        static void Main(string[] args)
        {

            Solution solution = new Solution();
            int[] ints = { -4, -1, 0, 3, 10 };


            solution.SortedSquares(ints);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int len = nums.Length;
            int[] arr = new int[len];
            for (int i = 0, j = len - 1, pos = len - 1; i <= j;)
            {
                if (nums[i] * nums[i] > nums[j] * nums[j])
                {
                    arr[pos] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    arr[pos] = nums[j] * nums[j];
                    j--;
                }

                pos--;
            }
            return arr;
        }
    }
}
