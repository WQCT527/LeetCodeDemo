using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128.最长连续序列
{
    internal class Program
    {

        /*
         给定一个未排序的整数数组 nums ，找出数字连续的最长序列（不要求序列元素在原数组中连续）的长度。

        请你设计并实现时间复杂度为 O(n) 的算法解决此问题。



        示例 1：

        输入：nums = [100,4,200,1,3,2]
        输出：4
        解释：最长数字连续序列是 [1, 2, 3, 4]。它的长度为 4。
        示例 2：

        输入：nums = [0,3,7,2,5,8,4,6,0,1]
        输出：9

         */
        static void Main(string[] args)
        {
            int[] nums = { -7, -1, 3, -9, -4, 7, -3, 2, 4, 9, 4, -9, 8, -7, 5, -1, -7 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                }
            }
            nums.ToList().ForEach(u => Console.Write(u + " "));
            Console.WriteLine("\n=====================================");
            Solution solution = new Solution();
            int res = solution.LongestConsecutive(nums);
            Console.WriteLine("res:");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }


    //public class Solution
    //{
    //    public int LongestConsecutive(int[] nums)
    //    {
    //        int len = 0;
    //        Stack<int> stack = new Stack<int>();
    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            int j;
    //            for (j = 0; j < nums.Length - 1 - i; j++)
    //            {
    //                if (nums[j] > nums[j + 1])
    //                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
    //            }
    //            //入栈
    //            if (stack.Count == 0 || stack.Peek() - nums[j] == 1)
    //            {
    //                stack.Push(nums[j]);
    //            }
    //            else if (stack.Peek() == nums[j])
    //            {
    //            }
    //            else
    //            {
    //                stack.Clear();
    //                stack.Push(nums[j]);
    //            }
    //            //
    //            if (stack.Count > len)
    //            {
    //                len = stack.Count;
    //            }
    //            stack.ToList().ForEach(u => Console.Write(u + " "));
    //            Console.WriteLine();
    //        }
    //        return len;
    //    }
    //}


    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            int len = 0;
            var hashtable = new Hashtable();
            //去重放进哈希表
            foreach (var item in nums)
            {
                if (!hashtable.ContainsKey(item))
                    hashtable[item] = null;
            }

            foreach (int item in hashtable.Keys)
            {
                //若存在上一个数字（item-1）
                if (hashtable.ContainsKey(item - 1))
                    continue;
                //不存在上一个数字，开始统计长度
                //循环查找下一个数字是否存在
                int temp = 1, curr = item + 1;
                while (hashtable.ContainsKey(curr))
                {
                    curr++;
                    temp++;
                }
                len = temp > len ? temp : len;
            }
            return len;
        }
    }
}
