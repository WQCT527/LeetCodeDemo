using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.在排序数组中查找元素的第一个和最后一个位置
{
    internal class Program
    {
        /*
         给你一个按照非递减顺序排列的整数数组 nums，和一个目标值 target。请你找出给定目标值在数组中的开始位置和结束位置。

        如果数组中不存在目标值 target，返回 [-1, -1]。

        你必须设计并实现时间复杂度为 O(log n) 的算法解决此问题。



        示例 1：

        输入：nums = [5,7,7,8,8,10], target = 8
        输出：[3,4]
        示例 2：

        输入：nums = [5,7,7,8,8,10], target = 6
        输出：[-1,-1]
        示例 3：

        输入：nums = [], target = 0
        输出：[-1,-1]


         */
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var arr = solution.SearchRange(new int[] { 2, 2 }, 0);
            Console.WriteLine($"[{arr[0]},{arr[1]}]");
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length <= 0)
            {
                return new int[] { -1, -1 };
            }
            //if (nums.Length == 1 && nums[0] != target)
            //{
            //    return new int[] { -1, -1 };
            //}


            int r = SearchRight(nums, target);
            int l = SearchLeft(nums, target);


            if (r == -1 || l == -1 || nums[r] != target || nums[l] != target)
            {
                return new int[] { -1, -1 };
            }

            return new int[] { l, r };
        }
        public int SearchRight(int[] nums, int target)
        {
            int left = -1;
            int right = nums.Length;
            int mid = 0;
            while (left + 1 != right)
            {
                mid = (left + right) / 2;
                if (nums[mid] <= target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }

            }

            return left;
        }

        public int SearchLeft(int[] nums, int target)
        {
            int left = -1;
            int right = nums.Length;
            int mid = 0;
            while (left + 1 != right)
            {
                mid = (left + right) / 2;
                if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }

            }

            return right;
        }
    }
}
