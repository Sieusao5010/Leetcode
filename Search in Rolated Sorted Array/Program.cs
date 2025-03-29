public class Program
{
    static void Main()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2, 3 };
        int target = 5;

        Solution solution = new Solution();
        int position = solution.Search(nums, target);

        Console.WriteLine("Vị trí của target cần tìm là: " + position);
    }
}