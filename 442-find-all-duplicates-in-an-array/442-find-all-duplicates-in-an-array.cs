public class Solution {
    public IList<int> FindDuplicates(int[] nums) {        
        Array.Sort(nums);
        List<int> res=new List<int>();
        for(int i=0;i<nums.Length-1;i++){
            int searchChar=nums[i];
            if(searchChar==nums[i+1]){
                res.Add(searchChar);
            }
            
            
        }
        return res;
    }
}