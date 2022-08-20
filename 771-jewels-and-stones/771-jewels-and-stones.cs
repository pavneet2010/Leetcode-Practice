public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        
        Dictionary<int,int> dict=new Dictionary<int,int>();
        foreach(char c in jewels){
            int result=c-'0';
            dict.Add(result,0);
        }
        foreach(char c in stones){
            int result=c-'0';
            if(dict.ContainsKey(result)){
                dict[result]++;
            }
        }
        //return dict.Count(k=>k.Values);
        int finalResult=0;
       foreach(var dick in dict){
         finalResult+=  dict[dick.Key];
       }
        return finalResult;
    }
}