﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.两数之和
{
    internal class Program
    {


        /*
        给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
        你可以假设每种输入只会对应一个答案，并且你不能使用两次相同的元素。
        你可以按任意顺序返回答案。



        示例 1：
        输入：nums = [2,7,11,15], target = 9
        输出：[0,1]
        解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
        示例 2：
        输入：nums = [3,2,4], target = 6
        输出：[1,2]
        示例 3：
        输入：nums = [3,3], target = 6
        输出：[0,1]
         */
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Hashtable ht = new Hashtable();
            //数组存入哈希表（key=数字，value=数组索引）
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (ht.ContainsKey(temp))
                {
                    return new int[] { (int)ht[temp], i };
                }
                else
                {
                    if (!ht.ContainsKey(nums[i]))
                        ht.Add(nums[i], i);
                }
            }
            return new int[] { };

        }
    }
}
