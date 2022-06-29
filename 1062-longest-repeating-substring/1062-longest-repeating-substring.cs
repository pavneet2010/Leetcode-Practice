public class Solution {
    public int LongestRepeatingSubstring(string s) {
        int res = 0;
        int left = 1;
        int right = s.Length;
        while(left < right)
        {
            int middle = left + (right - left) / 2;
            if(IsRepeating(s, middle))
            {
                left = middle + 1;
                res = middle;
            }
            else right = middle;
        }
        return res;
    }
    private bool IsRepeating(string s, int len)
    {
        HashSet<string> set = new HashSet<string>();
        for(int i = 0; i <= s.Length - len; i++)
        {
            var substring = s.Substring(i, len);
            if(set.Contains(substring)) return true;
            set.Add(substring);
        }
        return false;
    }
}