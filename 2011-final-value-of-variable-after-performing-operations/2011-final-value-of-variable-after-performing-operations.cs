public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
       Dictionary<string,int> dict=new Dictionary<string,int>();
        dict.Add("X++",1);
        dict.Add("++X",1);
        dict.Add("--X",-1);
        dict.Add("X--",-1);
        int res=0;
        foreach(string str in operations){
             if(dict.ContainsKey(str)){
                res+=dict[str];
             }   
        }
        return res;
    }
}