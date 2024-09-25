using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _844.比较含退格的字符串
{
    internal class Program
    {

        /*
         给定 s 和 t 两个字符串，当它们分别被输入到空白的文本编辑器后，如果两者相等，返回 true 。# 代表退格字符。

    注意：如果对空文本输入退格字符，文本继续为空。



    示例 1：

    输入：s = "ab#c", t = "ad#c"
    输出：true
    解释：s 和 t 都会变成 "ac"。
    示例 2：

    输入：s = "ab##", t = "c#d#"
    输出：true
    解释：s 和 t 都会变成 ""。
    示例 3：

    输入：s = "a#c", t = "b"
    输出：false
    解释：s 会变成 "c"，但 t 仍然是 "b"。
         */
        static void Main(string[] args)
        {
            string s = "xywrrmp";
            string t = "xywrrmu#p";
            Console.WriteLine(new Solution().BackspaceCompare(s, t));
        }
    }

    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            StringBuilder str1 = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '#')
                {
                    str1.Append(s[i]);
                }
                else
                {
                    if (str1.Length > 0)
                        str1.Remove(str1.Length - 1, 1);
                }
            }

            StringBuilder str2 = new StringBuilder();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != '#')
                {
                    str2.Append(t[i]);
                }
                else
                {
                    if (str2.Length > 0)
                        str2.Remove(str2.Length - 1, 1);
                }
            }
            return str1.Equals(str2);
        }
    }
}
