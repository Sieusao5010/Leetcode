using Container_with_most_water;

public class Program
{
    static void Main()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

        Solution1 solution1 = new Solution1();
        int result = solution1.MaxArea(height);

        Console.WriteLine($"Diện tích lớn nhất có thể chứa: {result}");
    }
}