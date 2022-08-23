public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> lookup = new Dictionary<int, int>();
        
        int count = 0;
        
        for(int i=0; i < nums.Length; i++)
        {
            if (lookup.ContainsKey(nums[i])) 
            {  
                count+= lookup[nums[i]]; 
                lookup[nums[i]]++;  
            }
            else
            {  lookup[nums[i]] = 1; }
        }
        
        return count;
    }
}