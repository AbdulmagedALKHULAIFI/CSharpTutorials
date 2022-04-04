using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Algos
{
    public class LinkedListSwapper
    {
        private ListNode _head = null;

        public ListNode SwapNodes(ListNode head, int k)
        {

            List<ListNode> nodes = new List<ListNode>();


            ListNode tmp = head;
            nodes.Add(tmp);

            while (tmp.next != null)
            {
                tmp = tmp.next;
                nodes.Add(tmp);
            }

            tmp = nodes[k + 1];
            nodes[k + 1].val = nodes[nodes.Count - 2].val;
            nodes[nodes.Count - 2].val = tmp.val;

            return nodes[0];
        }

        public ListNode CreateLinkedListFromList(List<int> intList) 
        {
            foreach(var item in intList)
            {
               Add(item);
            }

            return _head;
        }

        public void Add(int value)
        {
            var node = new ListNode { val = value };

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var current = _head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
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
