﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _704.二分查找
{
    internal class Program
    {
        /*
         给定一个 n 个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums 中的 target，如果目标值存在返回下标，否则返回 -1。


        示例 1:

        输入: nums = [-1,0,3,5,9,12], target = 9
        输出: 4
        解释: 9 出现在 nums 中并且下标为 4
        示例 2:

        输入: nums = [-1,0,3,5,9,12], target = 2
        输出: -1
        解释: 2 不存在 nums 中因此返回 -1
         */
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };

            Solution solution = new Solution();
            Console.WriteLine(solution.Search(nums, 9));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return -1;
        }
    }
}
