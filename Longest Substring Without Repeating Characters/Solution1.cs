namespace Longest_Substring_Without_Repeating_Characters
{
    public class Solution1
    {
        public (int, string) LongestSubstring(string s)
        {
            int n = s.Length;
            int left = 0;
            int startindex = 0;
            int maxlength = 0;
            HashSet<char> seen = new HashSet<char>();

            for (int right = 0; right < n; right++)
            {
                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;
                }

                seen.Add(s[right]);
                //maxlength = Math.Max(maxlength, right - left + 1);
                if (right - left + 1 > maxlength)
                {
                    startindex = left;
                    maxlength = right - left + 1;
                }
            }

            string longestSubstring = s.Substring(startindex, maxlength);
            return (maxlength, longestSubstring);
        }
    }
}
