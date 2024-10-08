using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.无重复字符的最长子串
{
    internal class Program
    {

        /*
         给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串的长度。

        示例 1:
        输入: s = "abcabcbb"
        输出: 3 
        解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
        示例 2:
        输入: s = "bbbbb"
        输出: 1
        解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
        示例 3:
        输入: s = "pwwkew"
        输出: 3
        解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
             请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
         */
        static void Main(string[] args)
        {
        }



    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            Queue<char> queue = new Queue<char>();
            foreach (char c in s)
            {
                while (queue.Contains(c))
                    queue.Dequeue();
                queue.Enqueue(c);
                if (queue.Count > length)
                {
                    length = queue.Count;
                }
            }
            return length;
        }
    }
}
