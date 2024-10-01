using System;

namespace _19.删除链表的倒数第_N_个结点
{
    internal class Program
    {
        /*
         给你一个链表，删除链表的倒数第 n 个结点，并且返回链表的头结点。
        输入：head = [1,2,3,4,5], n = 2
        输出：[1,2,3,5]
         */
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            Solution solution = new Solution();
            solution.RemoveNthFromEnd(head, 2);

            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
            Console.ReadLine();
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode org = new ListNode(0, head);
            ListNode slow = org;
            ListNode fast = org;
            while (n-- > 0 && fast.next != null)
            {
              
                fast = fast.next;
            }


            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return org.next;
        }
    }
}
