using Longest_Substring_Without_Repeating_Characters;

class Program
{
    static void Main()
    {
        Console.WriteLine("Solution 1: ");
        Console.Write("Nhập chuỗi: ");
        string input1 = Console.ReadLine(); 
        
        Solution1 solution1 = new Solution1();
        var  (maxlength1, longestSubstring1) = solution1.LongestSubstring(input1);

        Console.WriteLine($"Độ dài chuỗi con không lặp dài nhất: {maxlength1}");
        Console.WriteLine($"Chuỗi con không lặp dài nhất: {longestSubstring1}");

        Console.WriteLine("Solution 2: ");
        Console.Write("Nhập chuỗi: ");
        string input2 = Console.ReadLine();

        Solution2 solution2 = new Solution2();
        var (maxlength2, longestSubstring2) = solution2.LongestSubstring(input2);

        Console.WriteLine($"Độ dài chuỗi con không lặp dài nhất: {maxlength2}");
        Console.WriteLine($"Chuỗi con không lặp dài nhất: {longestSubstring2}");
    }
}