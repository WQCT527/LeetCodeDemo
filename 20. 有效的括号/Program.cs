using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.有效的括号
{
    internal class Program
    {
        /*
         给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

        有效字符串需满足：

        左括号必须用相同类型的右括号闭合。
        左括号必须以正确的顺序闭合。
        每个右括号都有一个对应的相同类型的左括号。


        示例 1：

        输入：s = "()"

        输出：true

        示例 2：

        输入：s = "()[]{}"

        输出：true

        示例 3：

        输入：s = "(]"

        输出：false

        示例 4：

        输入：s = "([])"

        输出：true



        提示：

        1 <= s.length <= 104
        s 仅由括号 '()[]{}' 组成
         */
        static void Main(string[] args)
        {
            Solution s = new Solution();
        }


    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '{' || item == '(' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();

                }
                else if (item == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();


                }
                else if (item == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();

                }
                else
                {
                    return false;
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
