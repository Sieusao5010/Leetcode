namespace Longest_Substring_Without_Repeating_Characters
{
    public class Solution2
    {
        public (int, string) LongestSubstring(string s)
        {
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();
            int left = 0;
            int starindex = 0;
            int maxlength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (lastSeen.ContainsKey(s[right]) && lastSeen[s[right]] >= left)
                {
                    left = lastSeen[s[right]] + 1;
                }

                lastSeen[s[right]] = right;            

                if (right - left + 1 > maxlength)
                {
                    maxlength = right - left + 1;
                    starindex = left;
                }
            }

            string longestSubstring = s.Substring(starindex, maxlength);
            return (maxlength, longestSubstring);
        }
    }
}
