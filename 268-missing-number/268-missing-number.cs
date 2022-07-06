public class Solution {
    public int MissingNumber(int[] nums) {
        int n=nums.Length;
         int sum=(n*(n+1))/2;
        foreach(int i in nums){
            sum-=i;
        }
        return sum;       
        
    }
}