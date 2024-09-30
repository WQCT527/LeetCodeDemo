using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.两两交换链表中的节点
{
    internal class Program
    {
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
        public ListNode SwapPairs(ListNode head)
        {
            ListNode org = new ListNode(0, head);

            ListNode curr = org;

            while (curr.next != null && curr.next.next != null)
            {
                ListNode temp1 = curr.next;
                ListNode temp2 = curr.next.next;
                ListNode temp3 = curr.next.next.next;

                curr.next = temp2;
                temp2.next = temp1;
                temp1.next = temp3;
                curr = curr.next.next;
            }
            return org.next;
        }
    }
}
