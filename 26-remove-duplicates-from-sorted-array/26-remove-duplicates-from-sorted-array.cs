public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
//         int count=0;
//         //Array.Sort(nums);
//         int temp=int.MaxValue;
//         foreach(int i in nums){
//             if(i!=temp){
//                 count++;
//                 temp=i;
                
//             }
//         }
//         return count;
        
        
        var count = ( nums.Length == 0 ? 0 : 1 );
        
        foreach( int num in nums )
            if ( nums[count-1] < num )
                nums[count++] = num;
                
        return count;
    }
}