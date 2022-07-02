public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        
        Dictionary<int,int> dict=new Dictionary<int,int>();
        int res=0;
        foreach(int i in time){
           var mod = i % 60;
        int key = mod != 0 ? 60 - mod : 0;

        if (dict.ContainsKey(key))
            res += dict[key];

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



 