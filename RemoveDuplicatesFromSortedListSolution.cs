using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveDuplicatesFromSortedListSolution
    {
        public ListNode DeleteDuplicates(ListNode head) {
            if (head == null) {
                return null;
            }
            ListNode node = head;

            while (node != null && node.next != null) {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                }
                else {
                    node = node.next;
                }
            }

            return head;
        }
    }
}
