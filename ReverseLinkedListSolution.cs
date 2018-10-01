using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head) {
            if (head == null)
            {
                return null;
            }

            ListNode first = head;
            ListNode cur = head;
            while (cur.next != null)
            {
                var next = cur.next;
                cur.next = next.next;
                next.next = first;
                first = next;
            }

            return first;
        }
    }
}
