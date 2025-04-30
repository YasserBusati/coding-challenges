namespace CodingChallenges.Arrays.ContainerWithMostWater;

public class ContainerWithMostWater
{

    public static void Run()
    {
        int[] height = [2, 7, 11, 15];
        int result = MaxArea(height);
        Console.WriteLine($"this is maximum area found: {result}");
    }
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            // Calculate current area
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            int currentArea = h * w;

            // Update max area if current is larger
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer from shorter line
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}