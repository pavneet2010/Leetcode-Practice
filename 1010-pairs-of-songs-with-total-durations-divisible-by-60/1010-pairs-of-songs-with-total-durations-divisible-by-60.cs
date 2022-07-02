public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        
        Dictionary<int,int> dict=new Dictionary<int,int>();
        int res=0;
        foreach(int i in time){
        int mod = i % 60;
        int complement = mod != 0 ? 60 - mod : 0;

        if (dict.ContainsKey(complement))
            res += dict[complement];

        if(!dict.ContainsKey(mod))
        {
            dict.Add(mod, 1);
        }
        else
        {
            dict[mod]++;
        }
        }
        return res;
        
    }
}



 