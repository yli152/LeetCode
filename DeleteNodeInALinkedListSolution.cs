using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //Copy the next node to the given node and delete the next one
    public class DeleteNodeInALinkedListSolution
    {
        public void DeleteNode(ListNode node) {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
