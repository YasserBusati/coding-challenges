namespace CodingChallenges.utils;

public static class ListNodeExtensions
{
    public static ListNode ToListNode(this int[] values)
    {
        if (values.Length == 0) return null;
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;
    }

    public static int[] LinkListToArray(this ListNode head)
    {
        var result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return [.. result];
    }
    public static List<int> NodeToList(this ListNode node)
    {
        List<int> result = [];
        while (node != null)
        {
            result.Add(node.val);
            node = node.next;
        }
        return result;
    }
}