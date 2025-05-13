using CodingChallenges.LinkedLists.RemoveNthNodeFromEndOfList;
using CodingChallenges.utils;

namespace tests.LinkedLists;
public class RemoveNthNodeFromEndOfListTests
{
    private static ListNode CreateList(int[] values)
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

    private static int[] ListToArray(ListNode head)
    {
        var result = new List<int>();
        while (head != null)
        {
            result.Add(head.val);
            head = head.next;
        }
        return result.ToArray();
    }

    [Fact]
    public void RemoveNthFromEnd_MiddleNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = CreateList([1, 2, 3, 4, 5]);
        int n = 2;
        int[] expected = { 1, 2, 3, 5 };

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, ListToArray(result));
    }

    [Fact]
    public void RemoveNthFromEnd_HeadNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = CreateList([1, 2]);
        int n = 2;
        int[] expected = { 2 };

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, ListToArray(result));
    }

    [Fact]
    public void RemoveNthFromEnd_LastNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = CreateList([1, 2]);
        int n = 1;
        int[] expected = { 1 };

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, ListToArray(result));
    }

    [Fact]
    public void RemoveNthFromEnd_SingleNode_ReturnsEmptyList()
    {
        // Arrange
        ListNode head = CreateList([1]);
        int n = 1;
        int[] expected = [];

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, ListToArray(result));
    }

    [Fact]
    public void RemoveNthFromEnd_LongListLargeN_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = CreateList([1, 2, 3, 4, 5, 6, 7]);
        int n = 5;
        int[] expected = [1, 2, 4, 5, 6, 7];

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, ListToArray(result));
    }
}