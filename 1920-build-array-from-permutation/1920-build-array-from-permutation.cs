public class Solution {
    public int[] BuildArray(int[] nums) {
        List<int> result=new List<int>();
        foreach(int i in nums){
            result.Add(nums[i]);
        }
        return result.ToArray();
    }
}