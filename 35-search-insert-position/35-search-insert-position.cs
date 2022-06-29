public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int i=0;
        while(i<nums.Length){
            if(target==nums[i]){
                return i;
            }else if(target>nums[i]){
                i++;
            }else if(target<nums[i]){
                return i;
            }
            
        }
        return i;
        
        
    }
}