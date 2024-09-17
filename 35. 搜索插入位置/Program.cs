using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.搜索插入位置
{
    internal class Program
    {
        /*给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。

        请必须使用时间复杂度为 O(log n) 的算法。
        
        输入: nums = [1,3,5,6], target = 5
        输出: 2
        示例 2:

        输入: nums = [1,3,5,6], target = 2
        输出: 1
        示例 3:

        输入: nums = [1,3,5,6], target = 7
        输出: 4
         
         */
        static void Main(string[] args)

        {

            int[] nums = new int[] { 1, 3, 5, 6 };

            Solution solution = new Solution();
            var i = solution.SearchInsert(nums, 2);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int mid = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }


            return left;
        }
    }

}
