using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            else if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else {
                if (l1.val <= l2.val)
                {
                    ListNode result = new ListNode(l1.val);
                    result.next = null;
                }
                else {
                    ListNode result = new ListNode(l2.val);
                    result.next = null;
                }
                
                while (l1 != null && l2 != null) {

                }
            }
        }
    }
}
