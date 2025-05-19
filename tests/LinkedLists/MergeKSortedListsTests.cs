using CodingChallenges.LinkedLists.MergeKSortedLists;
using CodingChallenges.utils;

namespace tests.LinkedLists;

public class MergeKSortedListsTests
{
    [Fact]
    public void MergeKLists_ShouldMergeCorrectly()
    {
        // Arrange

        ListNode[] lists =
        [
            new int[] {1, 4, 5}.ToListNode(),
            new int[] {1, 3, 4}.ToListNode(),
            new int[] {2, 6}.ToListNode()
        ];

        var expected = new List<int> { 1, 1, 2, 3, 4, 4, 5, 6 };

        // Act
        var result = MergeKSortedLists.MergeKLists(lists);
        var resultList = result.LinkListToArray();

        // Assert
        Assert.Equal(expected, resultList);
    }

    [Fact]
    public void MergeKLists_WithEmptyLists_ReturnsEmpty()
    {

        ListNode[] lists = [null, null];

        var result = MergeKSortedLists.MergeKLists(lists);
        Assert.Null(result);
    }

    [Fact]
    public void MergeKLists_SingleList_ReturnsSameList()
    {
        var inputList = new int[] { 1, 2, 3 }.ToListNode();

        ListNode[] lists = [inputList];

        var result = MergeKSortedLists.MergeKLists(lists);
        var resultList = result.LinkListToArray();

        Assert.Equal(new List<int> { 1, 2, 3 }, resultList);
    }
}
