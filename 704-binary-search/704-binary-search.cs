public class Solution {
    public int Search(int[] nums, int target) {
        int start=0;
        int end=nums.Length-1;
        if(nums.Length==1 && nums[0]==target){
            return 0;
        }else if(nums.Length==1 && nums[0]!=target){
            return -1;
        }
        while(start<=end){
            int mid=start +(end-start)/2;
            //Console.Write(mid);
            if(nums[mid]==target){
                return mid;
            }
            if(target>nums[mid]){
                start++;
            }else if(target<nums[mid]){
                end--;
            }
        }
        return -1;
    }
}