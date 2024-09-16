using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.两数相加
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
            请你将两个数相加，并以相同形式返回一个表示和的链表。
            你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
            输入：l1 = [2,4,3], l2 = [5,6,4]
            输出：[7,0,8]
            解释：342 + 465 = 807.
             */
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9)));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9))));
            Solution solution = new Solution();
            var res = solution.AddTwoNumbers(l1, l2);

            while (res != null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode current = head;
            int sum = 0;
            int jinwei = 0;
            while (l1 != null || l2 != null)
            {
                int a = l1 == null ? 0 : l1.val;
                int b = l2 == null ? 0 : l2.val;
                sum =  jinwei + a + b;
                jinwei = sum >= 10 ? 1 : 0;
                current.next = new ListNode(sum % 10);
                current = current.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (jinwei!=0)
            {
                current.next = new ListNode(jinwei);
            }
            return head.next;
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

}
