using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _707.设计链表
{
    internal class Program
    {
        /*
         你可以选择使用单链表或者双链表，设计并实现自己的链表。

    单链表中的节点应该具备两个属性：val 和 next 。val 是当前节点的值，next 是指向下一个节点的指针/引用。

    如果是双向链表，则还需要属性 prev 以指示链表中的上一个节点。假设链表中的所有节点下标从 0 开始。

    实现 MyLinkedList 类：

    MyLinkedList() 初始化 MyLinkedList 对象。
    int get(int index) 获取链表中下标为 index 的节点的值。如果下标无效，则返回 -1 。
    void addAtHead(int val) 将一个值为 val 的节点插入到链表中第一个元素之前。在插入完成后，新节点会成为链表的第一个节点。
    void addAtTail(int val) 将一个值为 val 的节点追加到链表中作为链表的最后一个元素。
    void addAtIndex(int index, int val) 将一个值为 val 的节点插入到链表中下标为 index 的节点之前。如果 index 等于链表的长度，那么该节点会被追加到链表的末尾。如果 index 比长度更大，该节点将 不会插入 到链表中。
    void deleteAtIndex(int index) 如果下标有效，则删除链表中下标为 index 的节点。


    示例：

    输入
    ["MyLinkedList", "addAtHead", "addAtTail", "addAtIndex", "get", "deleteAtIndex", "get"]
    [[], [1], [3], [1, 2], [1], [1], [1]]
    输出
    [null, null, null, null, 2, null, 3]

    解释
    MyLinkedList myLinkedList = new MyLinkedList();
    myLinkedList.addAtHead(1);
    myLinkedList.addAtTail(3);
    myLinkedList.addAtIndex(1, 2);    // 链表变为 1->2->3
    myLinkedList.get(1);              // 返回 2
    myLinkedList.deleteAtIndex(1);    // 现在，链表变为 1->3
    myLinkedList.get(1);              // 返回 3

         */
        static void Main(string[] args)
        {
        }
    }

    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val) { this.val = val; }
    }
    public class MyLinkedList
    {
        ListNode dummyHead;
        int count;

        public MyLinkedList()
        {
            dummyHead = new ListNode(0);
            count = 0;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
                return -1;
            ListNode current = dummyHead.next;
            while (index > 0)
            {
                current = current.next;
                index--;
            }
            return current.val;
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        public void AddAtTail(int val)
        {
            AddAtIndex(count, val);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > count) return;
            ListNode current = dummyHead.next;
            while (index > 1)
            {
                current = current.next;
                index--;
            }


            ListNode newList = new ListNode(val);
            newList.next = current.next.next;
            current.next = newList;
            count++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index >= count || index < 0) return;
            var tmp1 = dummyHead;
            for (int i = 0; i < index; i++)
            {
                tmp1 = tmp1.next;
            }
            tmp1.next = tmp1.next.next;
            count--;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
