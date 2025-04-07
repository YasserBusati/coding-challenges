using CodingChallenges.LinkedLists;
using CodingChallenges.utils;

namespace tests.LinkedLists;

public class AddTwoNumberTests
{
    [Fact]
    public void Test_AddTwoNumbers_Case1()
    {
        // Arrange
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // 342
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // 465


        // Act
        var result = Solution.AddTwoNumbers(l1, l2); // 807

        // Assert
        var expected = new ListNode(7, new ListNode(0, new ListNode(8))); // 807
        Assert.Equal(expected.NodeToList(), result.NodeToList());
    }

    [Fact]
    public void Test_AddTwoNumbers_Case2()
    {
        // Arrange
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);


        // Act
        var result = Solution.AddTwoNumbers(l1, l2); // 0

        // Assert
        var expected = new ListNode(0);
        Assert.Equal(expected.NodeToList(), result.NodeToList());
    }

    [Fact]
    public void Test_AddTwoNumbers_Case3()
    {
        // Arrange
        var l1 = new ListNode(9, new ListNode(9)); // 99
        var l2 = new ListNode(1); // 1


        // Act
        var result = Solution.AddTwoNumbers(l1, l2); // 100

        // Assert
        var expected = new ListNode(0, new ListNode(0, new ListNode(1))); // 100
        Assert.Equal(expected.NodeToList(), result.NodeToList());
    }

}
