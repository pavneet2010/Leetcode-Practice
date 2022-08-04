public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        List<int> firstList=new  List<int>();
        List<int> secondList=new  List<int>();
        List<int> resultList=new  List<int>();
        for(int i=0;i<n;i++){
            firstList.Add(nums[i]);
            secondList.Add(nums[n+i]);
        }
//         for(int i=n;i<nums.Length;i++){
//             secondList.Add(nums[i]);
//         }
        
        int length=firstList.Count()>secondList.Count()?firstList.Count():secondList.Count();
        
        for(int j=0;j<length;j++){            
             resultList.Add(firstList[j]);
             resultList.Add(secondList[j]);
        }
        return resultList.ToArray();
        
    }
}