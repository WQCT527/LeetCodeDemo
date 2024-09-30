using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206.反转链表
{
    internal class Program
    {
        /*
         给你单链表的头节点 head ，请你反转链表，并返回反转后的链表。
        输入：head = [1,2,3,4,5]
        输出：[5,4,3,2,1]
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
        public ListNode ReverseList(ListNode head)
        {

            ListNode temp;
            ListNode curr = head;
            ListNode pre = null;
            while (curr != null)
            {
                temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }

            return pre;

        }
    }
}
