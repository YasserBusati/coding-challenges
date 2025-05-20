using CodingChallenges.utils;

namespace CodingChallenges.LinkedLists.SwapNodesInPairs;

public class SwapNodesInPairs
{
    public static ListNode SwapPairs(ListNode head)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode current = dummy;

        while (current.next != null && current.next.next != null)
        {
            // Nodes to be swapped
            ListNode first = current.next;
            ListNode second = current.next.next;

            // Swapping
            first.next = second.next;
            second.next = first;
            current.next = second;

            // Move to the next pair
            current = current.next.next;
        }

        return dummy.next;
    }
}