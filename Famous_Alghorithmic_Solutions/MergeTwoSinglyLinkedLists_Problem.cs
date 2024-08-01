using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
   
    internal class MergeTwoSinglyLinkedLists_Problem
    {
        public void Test()
        {
            var list1 = new ListNode();
            ImportData(list1, new int[] { 1, 2, 4 });
            var list2 = new ListNode();
            ImportData(list2, new int[] { 1, 3, 4 });

            var res = MergeTwoLists(list1, list2);

        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var finalList = new ListNode();
            var response= Merge(finalList, list1, list2);
            return response;
        }

        public ListNode Merge(ListNode finalNode, ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.val <= list2.val)
            {
                finalNode = list1;
                finalNode.next = Merge(finalNode, list1.next, list2);
            }
            else
            {
                finalNode = list2;
                finalNode.next = Merge(finalNode, list1, list2.next);
            }

            return finalNode;
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
