using CodingChallenges.LinkedLists.RemoveNthNodeFromEndOfList;
using CodingChallenges.utils;

namespace tests.LinkedLists;

public class RemoveNthNodeFromEndOfListTests
{

    [Fact]
    public void RemoveNthFromEnd_MiddleNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2, 3, 4, 5 }.ToListNode();
        int n = 2;
        int[] expected = { 1, 2, 3, 5 };

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void RemoveNthFromEnd_HeadNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2 }.ToListNode();
        int n = 2;
        int[] expected = { 2 };

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void RemoveNthFromEnd_LastNode_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2 }.ToListNode();
        int n = 1;
        int[] expected = [1];

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void RemoveNthFromEnd_SingleNode_ReturnsEmptyList()
    {
        // Arrange
        ListNode head = new int[] { 1 }.ToListNode();
        int n = 1;
        int[] expected = [];

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void RemoveNthFromEnd_LongListLargeN_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2, 3, 4, 5, 6, 7 }.ToListNode();
        int n = 5;
        int[] expected = [1, 2, 4, 5, 6, 7];

        // Act
        ListNode result = RemoveNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }
}