public class Solution {
    public int[] RunningSum(int[] nums) {
        if(nums.Length==0){
            return new int[nums.Length];
        }
        for(int i =1;i<nums.Length;i++){
            nums[i]+=nums[i-1];
        }   
        return nums;
    }
    
}