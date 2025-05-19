using CodingChallenges.utils;

namespace CodingChallenges.LinkedLists.MergeKSortedLists;

public class MergeKSortedLists
{
    public static void Run()
    {
        ListNode[] lists =
        [
            new int[] {1, 4, 5}.ToListNode(),
            new int[] {1, 3, 4}.ToListNode(),
            new int[] {2, 6}.ToListNode()
        ];
        var result = MergeKLists(lists);
        Console.WriteLine($"sorted list is {result}");
    }
    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0) return null;

        // Create a min-heap (priority queue) sorted by node values
        var priorityQueue = new PriorityQueue<ListNode, int>();

        // Add the head of each list to the priority queue
        foreach (var list in lists)
        {
            if (list != null)
            {
                priorityQueue.Enqueue(list, list.val);
            }
        }

        // Dummy node to build the result list
        ListNode dummy = new();
        ListNode current = dummy;

        while (priorityQueue.Count > 0)
        {
            // Get the node with smallest value
            var node = priorityQueue.Dequeue();

            // Add it to the result list
            current.next = node;
            current = current.next;

            // If the node has a next element, add it to the queue
            if (node.next != null)
            {
                priorityQueue.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}