public class Solution {
    public int ThirdMax(int[] nums) {
         if(nums.Length == 1)
        {
            return nums[0];
        }
        
        if(nums.Length == 2)
        {
           return nums[0] > nums[1] ? nums[0] : nums[1];
        }
        
        
        var i = 0;
        var j = 1;   
        
        while(i <= 3)
        {
            if(j > nums.Length - 1)
            {
                i++;
                
                if (i == nums.Length - 1)
                {
                    break;
                }
                
                j = i + 1;
            }
            
            if(nums[i] < nums[j])
            {
                var t = nums[i];
                nums[i] = nums[j];
                nums[j] = t;
            }
            
            j++;
        }
        
        var hashSet = new HashSet<int>(3);
        var count = 3;
        
        for(var k = 0; k < count; k++)
        {
            var result = hashSet.Add(nums[k]);
            
            if(!result && nums.Length > count)
            {
                count++;
            }
        }
        
        return hashSet.Count >= 3 ? hashSet.Min() : hashSet.Max();
        
    }
}