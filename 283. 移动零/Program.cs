using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283.移动零
{
    internal class Program
    {

        /*
         给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

        请注意 ，必须在不复制数组的情况下原地对数组进行操作。



        示例 1:
        输入: nums = [0,1,0,3,12]
        输出: [1,3,12,0,0]
        示例 2:
        输入: nums = [0]
        输出: [0]
         */
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };

            Solution solution = new Solution();
            solution.MoveZeroes(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {

            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {

                if (nums[fast] != 0)
                {
                    int temp = nums[fast];
                    nums[fast] = 0;
                    nums[slow] = temp;
                    slow++;
                }

            }
        }
    }
}
