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

            int[] nums = new int[] { 1, 3 };

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
            int head = 0;
            int tail = nums.Length - 1;

            while (head <= nums.Length / 2)
            {
                if (nums[head] == target)
                {
                    return head;
                }
                else if (nums[tail] == target)
                {
                    return tail;
                }
                else if (nums[head] > target)
                {
                    return head;
                }
                else if (head < nums.Length - 1 && nums[head] < target && nums[head + 1] > target)
                {
                    return head + 1;
                }
                else
                if (tail > 0 && nums[tail - 1] < target && nums[tail] > target)
                {
                    return tail;
                }
                tail--;
                head++;
            }
            return nums.Length;
        }
    }

    //public class Solution
    //{
    //    public int SearchInsert(int[] nums, int target)
    //    {
    //        //for (int i = 0; i < nums.Length; i++)
    //        //{
    //        //    if (nums[i] == target)
    //        //    {
    //        //        return i;
    //        //    }
    //        //    else if (i == 0 && nums[i] > target)
    //        //    {
    //        //        return 0;
    //        //    }
    //        //    else if ((i == nums.Length - 1 && nums[i] < target) || (nums[i] < target && nums[i + 1] > target))
    //        //    {
    //        //        return i + 1;
    //        //    }
    //        //}
    //        //return 0;


    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            if (nums[i] == target || nums[i] > target)
    //            {
    //                return i;
    //            }
    //        }
    //        return nums.Length;
    //    }
    //}
}
