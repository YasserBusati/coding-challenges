using CodingChallenges.utils;

namespace CodingChallenges.LinkedLists.MergeTwoSortedLists;

public class MergeTwoSortedLists
{
    public static void Run()
    {
        ListNode l1 = new(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new(1, new ListNode(3, new ListNode(4)));
        ListNode result = MergeTwoLists(l1, l2);
        Console.WriteLine($"Merge List: {result}");

    }
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new(0);
        ListNode current = dummy;

        // Traverse both lists and link the smaller node each time
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Attach the remaining elements of list1 or list2
        if (list1 != null)
        {
            current.next = list1;
        }
        else if (list2 != null)
        {
            current.next = list2;
        }

        return dummy.next;
    }
}