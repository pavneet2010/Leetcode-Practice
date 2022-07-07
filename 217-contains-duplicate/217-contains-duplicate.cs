public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        foreach(int i in nums){
            if(!dict.ContainsKey(i)){
                dict.Add(i,1);
        }else{
                dict[i]++;
            }
        }
        var res=dict.Where(k=>k.Value>1);
        if(res.Count()>0){
            return true;
        }
        return false;
        
}
}