using _3Sum;

class Program
{
    static void Main()
    {
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        Solution1 solution = new Solution1();
        IList<IList<int>> result = solution.ThreeSum(nums);

        Console.WriteLine("Các bộ ba có tổng bằng 0:");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
}