public class Solution {
    public int ThirdMax(int[] nums) {
        var hs = new HashSet<int>(nums);
            if (hs.Count < 3) return hs.Max();
            return hs.OrderByDescending(n => n).Take(3).Last();
        
    }
}