using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    public class RemoveDulicatesFromSinglyLinkedList_Problem
    {
        public void Test()
        {
            var list1 = new ListNode();
            // ImportData(list1, new int[] {1,1,1});
            ImportData(list1, new int[] { 1, 2, 2, 3, 3 });

            var res = DeleteDuplicates(list1);

        }
        public static ListNode DeleteDuplicates(ListNode head)
        {

            if (head != null)
            {
                // create new node
                ListNode current = head;
                // loop
                while (current.next != null)
                {
                    if (current.val == current.next.val)
                    {
                        ListNode temp = current.next;
                        current.next = temp.next;
                    }
                    else
                    {
                        // iterate and ignore 
                        current = current.next;
                    }
                }
            }
            return head;
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
        public static void ImportData(ListNode rootNode, int[] values)
        {
            rootNode.val = values[0];
            for (int i = 1; i < values.Length; i++)
                AddNode(rootNode, values[i]);

        }

        public static void AddNode(ListNode rootNode, int val)
        {
            if (rootNode.next is null)
                rootNode.next = new ListNode(val);
            else
                AddNode(rootNode.next, val);

        }
    }
}
