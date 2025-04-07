namespace CodingChallenges.utils;

public static class Extensions
{
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