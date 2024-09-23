using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.删除有序数组中的重复项
{
    internal class Program
    {
        /*
         给你一个 非严格递增排列 的数组 nums ，请你 原地 删除重复出现的元素，使每个元素 只出现一次 ，
        返回删除后数组的新长度。元素的 相对顺序 应该保持 一致 。然后返回 nums 中唯一元素的个数。
        考虑 nums 的唯一元素的数量为 k ，你需要做以下事情确保你的题解可以被通过：
        更改数组 nums ，使 nums 的前 k 个元素包含唯一元素，并按照它们最初在 nums 中出现的顺序排列。nums 的其余元素与 nums 的大小不重要。
        返回 k 。
        示例 1：
        输入：nums = [1,1,2]
        输出：2, nums = [1,2,_]
        解释：函数应该返回新的长度 2 ，并且原数组 nums 的前两个元素被修改为 1, 2 。不需要考虑数组中超出新长度后面的元素。
        示例 2：
        输入：nums = [0,0,1,1,1,2,2,3,3,4]
        输出：5, nums = [0,1,2,3,4]
        解释：函数应该返回新的长度 5 ， 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4 。不需要考虑数组中超出新长度后面的元素。
         */
        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Solution solution = new Solution();
            int k = solution.RemoveDuplicates(arr);
            Console.WriteLine("k==" + k);
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[slow] == nums[fast])
                {
                    continue;
                }
                else
                {
                    slow++;
                    nums[slow] = nums[fast];
                }
            }
            return slow + 1;
        }
    }
}
