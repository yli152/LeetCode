using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveLinkedListElementsSolution
    {
        //DummyHead
        public ListNode RemoveElements(ListNode head, int val) {
            if (head == null)
            {
                return null;
            }

            ListNode dummyHead = new ListNode(-1);
            dummyHead.next = head;

            ListNode curNode = dummyHead;

            while (curNode.next != null) {
                if (curNode.next.val == val)
                {
                    curNode.next = curNode.next.next;
                }
                else {
                    curNode = curNode.next;
                }
            }

            return dummyHead.next;
        }
    }
}
