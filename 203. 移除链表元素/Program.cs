using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203.移除链表元素
{
    internal class Program
    {
        /*
         给你一个链表的头节点 head 和一个整数 val ，请你删除链表中所有满足 Node.val == val 的节点，并返回 新的头节点 。

    示例 1：
    输入：head = [1,2,6,3,4,5,6], val = 6
    输出：[1,2,3,4,5]
    示例 2：

    输入：head = [], val = 1
    输出：[]
    示例 3：

    输入：head = [7,7,7,7], val = 7
    输出：[]

         */
        static void Main(string[] args)
        {
        }
    }




    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode start = new ListNode(0, head);
            ListNode temp = start;
            while (temp.next != null)
            {
                if (temp.next.val == val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }

            return start.next;
        }
    }
}
