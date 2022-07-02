public class Solution {
    public string ReverseWords(string s) {
        // StringBuilder result=new StringBuilder();
        string result="";
        
        List<string> splitStr=s.Split(" ").ToList();
        
        // foreach(string str in splitStr){
        //     result+=str;
        // }
        for(int i=splitStr.Count-1;i>=0;i--){
            if(!String.IsNullOrEmpty(splitStr[i]))
            result+=splitStr[i].Trim()+" ";
        }
        return result.Trim();
    }
}