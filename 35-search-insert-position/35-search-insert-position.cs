public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
            int first=0;
            int last= nums.Length-1;
            int mid;

            while(first<=last){
                 mid= first + ((last - first) / 2);

            if(nums[mid]==target){
                return mid;
            }
            if(target>nums[mid]){
                first=mid+1;
                
            }else{
                last=mid-1;
            }
            }
            return first;        
    }
}