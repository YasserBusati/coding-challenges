using CodingChallenges.LinkedLists.SwapNodesInPairs;
using CodingChallenges.utils;

namespace tests.LinkedLists;

public class SwapNodesInPairsTests
{
    [Fact]
    public void SwapPairs_EvenLengthList_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2, 3, 4 }.ToListNode();
        int[] expected = { 2, 1, 4, 3 };

        // Act
        ListNode result = SwapNodesInPairs.SwapPairs(head);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void SwapPairs_OddLengthList_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2, 3 }.ToListNode();
        int[] expected = { 2, 1, 3 };

        // Act
        ListNode result = SwapNodesInPairs.SwapPairs(head);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void SwapPairs_SingleNode_ReturnsSameList()
    {
        // Arrange
        ListNode head = new int[] { 1 }.ToListNode();
        int[] expected = { 1 };

        // Act
        ListNode result = SwapNodesInPairs.SwapPairs(head);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void SwapPairs_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        ListNode head = new int[] { }.ToListNode();
        int[] expected = { };

        // Act
        ListNode result = SwapNodesInPairs.SwapPairs(head);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void SwapPairs_LargeList_ReturnsCorrectList()
    {
        // Arrange
        ListNode head = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }.ToListNode();
        int[] expected = { 2, 1, 4, 3, 6, 5, 8, 7 };

        // Act
        ListNode result = SwapNodesInPairs.SwapPairs(head);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }
}