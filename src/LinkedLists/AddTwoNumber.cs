
using System.Collections.Generic;
using CodingChallenges.utils;
namespace CodingChallenges.LinkedLists;
public class Solution
{
    public static void Run()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // 342
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // 465
        var result = AddTwoNumbers(l1, l2);
        PrintList(result);
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode current = result;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            sum %= 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        return result.next;
    }

    private static void PrintList(ListNode node)
    {
        var values = new List<int>();
        while (node != null)
        {
            values.Add(node.val);
            node = node.next;
        }
        Console.WriteLine(string.Join(" -> ", values));
    }
}
