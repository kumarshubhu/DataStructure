using System;
using static LeetCode.LinkedList;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deletion del = new Deletion();
            //int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 4};
            //int result = del.removeDuplicates(arr);
            //SinglyLinkedList sll = new SinglyLinkedList();
            //sll.InsertNodeAtFront(sll, 2);
            //sll.InsertDataAtLast(sll, 3);
            //sll.InsertAfter(new node(2), 4);
            //sll.DeleteNode(new node(3));
            //sll.DeleteNode(new node(2));
            MyLinkedList mll = new MyLinkedList();
            mll.AddAtHead(1);
            mll.AddAtTail(3);
            mll.AddAtIndex(1, 2);
            int result = mll.Get(1);
            mll.DeleteAtIndex(1);
           int result1 = mll.Get(1);
        }
    }
}
