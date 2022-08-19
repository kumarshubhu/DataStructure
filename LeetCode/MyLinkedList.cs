using System;
namespace LeetCode
{
    public class MyLinkedList
    {

        public node head;
        public MyLinkedList()
        {
            head = null;
        }

        public class node
        {
            public node next;
            public int data;
            public node(int a)
            {
                data = a;
                next = null;
            }
        }


        public int Get(int index)
        {
            int indexCount = 0;
            node index_node = head;
            //node prev_node = null;
            while ( indexCount != index)
            {
                indexCount++;
                index_node = index_node.next;
            }
            //if(val)
            return index_node.data;
            //return 2;
        }

        public void AddAtHead(int val)
        {
            node new_node = new node(val);
            new_node.next = this.head;
            this.head = new_node;
        }

        public void AddAtTail(int val)
        {
            node new_node = new node(val);
            node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new_node;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            node new_node = new node(val);
            int indexCount = 0;
            node index_node = this.head;
            node prev_node = null;
            while (index_node.next != null && indexCount != index)
            {
                indexCount++;
                prev_node = index_node;
                index_node = index_node.next;
            }
            prev_node.next = new_node;
            new_node.next = index_node;
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                this.head = null;
            }
            int indexCount = 0;
            node index_node = this.head;
            node prev_node = null;
            while (index_node.next != null && indexCount != index)
            {
                prev_node = index_node;
                index_node = index_node.next;
            }
            prev_node.next = index_node.next;
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
