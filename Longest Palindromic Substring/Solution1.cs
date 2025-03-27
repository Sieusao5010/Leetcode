namespace Longest_Palindromic_Substring
{
    public class Solution1
    {
        public string LongestPalindrome(string s)
        {
            int maxlength = 0;
            int startIndex = 0;
            int left, right;
            for (int i = 0; i < s.Length; i++)
            {
                left = i;
                right = i;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    int length = right - left + 1;
                    if (length > maxlength)
                    {
                        maxlength = length;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    int length = right - left + 1;
                    if (length > maxlength)
                    {
                        maxlength = length;
                        startIndex = left;
                    }
                    left--;
                    right++;
                }
            }

            return s.Substring(startIndex, maxlength);
        }
    }
}
