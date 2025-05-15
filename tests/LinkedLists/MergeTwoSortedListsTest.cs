using CodingChallenges.LinkedLists.MergeTwoSortedLists;
using CodingChallenges.utils;

namespace tests.LinkedLists;

public class MergeTwoSortedListsTest
{
    [Fact]
    public void Test_MergeTwoNonEmptyLists()
    {
        // Arrange
        ListNode l1 = new int[] { 1, 2, 4 }.ToListNode();
        ListNode l2 = new int[] { 1, 3, 4 }.ToListNode();
        int[] expected = [1, 1, 2, 3, 4, 4];

        // Act
        ListNode result = MergeTwoSortedLists.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void Test_MergeEmptyAndNonEmptyList()
    {
        // Arrange
        ListNode l1 = null;
        ListNode l2 = new int[] { 0 }.ToListNode();
        int[] expected = [0];

        // Act
        ListNode result = MergeTwoSortedLists.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void Test_MergeTwoEmptyLists()
    {
        // Arrange
        ListNode l1 = null;
        ListNode l2 = null;
        int[] expected = [];

        // Act
        ListNode result = MergeTwoSortedLists.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }

    [Fact]
    public void Test_MergeListsWithSingleNode()
    {
        // Arrange
        ListNode l1 = new int[] { 1 }.ToListNode();
        ListNode l2 = new int[] { 2 }.ToListNode();
        int[] expected = [1, 2];

        // Act
        ListNode result = MergeTwoSortedLists.MergeTwoLists(l1, l2);

        // Assert
        Assert.Equal(expected, result.LinkListToArray());
    }
}
