public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        Dictionary<string,string> dict=new Dictionary<string,string>();
        string output=String.Empty;
        foreach(IList<string> str in paths){
            
            if(!dict.ContainsKey(str[0])){
                dict.Add(str[0],str[1]);
            }                
        }
        
        foreach(var dick in dict){
          if(!dict.ContainsKey(dick.Value)){
              output=dick.Value;
          }
        }
        return output;
        
    }
}