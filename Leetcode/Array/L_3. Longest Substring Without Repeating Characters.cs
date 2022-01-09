// https://leetcode.com/problems/longest-substring-without-repeating-characters/ 

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == null || s == String.Empty)
                return 0;
        int max = 0;
        int l = 0;
        int r = 0;
        Dictionary<char, int> hash = new Dictionary<char, int>();
        while(r < s.Length)
        {
           if(!hash.ContainsKey(s[r]))
           {
               hash.Add(s[r],  r++);               
               max = Math.Max(max, r  - l);
           }
           else
           {
                hash.Remove(s[l++]);
           }
        }
        return max;
    }
}
