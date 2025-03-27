using Longest_Palindromic_Substring;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập chuỗi:");
        string input = Console.ReadLine();
        Solution1 solution = new Solution1();
        string longestPalindrome = solution.LongestPalindrome(input);
        Console.WriteLine("Chuỗi con đối xứng dài nhất:" + longestPalindrome);
    }
}