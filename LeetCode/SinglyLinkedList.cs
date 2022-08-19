using System;
namespace LeetCode
{
    public class LinkedList
    {
        internal class node
        {
            internal int data;
            internal node next;
            public node(int t)
            {
                data = t;
                next = null;
            }
        }

        internal class SinglyLinkedList
        {
            internal node head;

            internal void InsertNodeAtFront(SinglyLinkedList singlyList, int t)
            {
                node newnode = new node(t);
                newnode.next = singlyList.head;
                singlyList.head = newnode;
            }

            internal void InsertDataAtLast(SinglyLinkedList singlylist, int t)
            {
                node newnode = new node(t);
                if (singlylist.head == null)
                {
                    singlylist.head = newnode;
                    return;
                }
                node lastnode = GetLastNode(singlylist);
                lastnode.next = newnode;
            }

            internal node GetLastNode(SinglyLinkedList singlyList)
            {
                node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            internal void InsertAfter(node prev_node, int t)
            {
                if(prev_node == null)
                {
                    return;
                }
                node newnode = new node(t);
                node foundednode = FindPassedNode(this, prev_node);
                newnode.next = foundednode.next;
                foundednode.next = newnode;
            }

            internal void DeleteNode(node del_node)
            {
                if (del_node == null)
                {
                    return;
                }
                node temp = this.head;
                if(temp.data == del_node.data)
                {
                    this.head = this.head.next;
                    return;
                }
                node prev = null;
                while(temp.data != del_node.data)
                {
                    prev = temp;
                    temp = temp.next;
                }
                prev.next = temp.next;
            }

            internal node FindPassedNode(SinglyLinkedList list, node tofindnode)
            {
                node temp = list.head;
                while(temp.data != tofindnode.data)
                {
                    temp = temp.next;
                }
                return temp;
            }
        }

        

        //internal void InsertAfter(SinglyLinkedList singlylist, node prev_node, int t)
        //{
        //    node newnode = new node(t);
        //    while()
        //}

        
    }
}
