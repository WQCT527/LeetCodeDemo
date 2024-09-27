using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209.长度最小的子数组
{
    internal class Program
    {

        /*
         给定一个含有 n 个正整数的数组和一个正整数 target 。

        找出该数组中满足其总和大于等于 target 的长度最小的 
        子数组
         [numsl, numsl+1, ..., numsr-1, numsr] ，并返回其长度。如果不存在符合条件的子数组，返回 0 。

        示例 1：
        输入：target = 7, nums = [2,3,1,2,4,3]
        输出：2
        解释：子数组 [4,3] 是该条件下的长度最小的子数组。
        示例 2：
        输入：target = 4, nums = [1,4,4]
        输出：1
        示例 3：
        输入：target = 11, nums = [1,1,1,1,1,1,1,1]
        输出：0
         */
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MinSubArrayLen(7, nums)); 
        Console.ReadLine();
        }
    }

    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int start = 0;
            int end = 0;
            int sum = 0;
            int len = nums.Length + 1;
            while (end < nums.Length)
            {

                sum += nums[end];
                while (sum >= target)
                {
                    len = len < end - start + 1 ? len : end - start + 1;
                    sum -= nums[start++];
                }
                
                end++;
            }
            return len == nums.Length + 1 ? 0 : len;
        }
    }
}
