public class Solution {
    public bool BackspaceCompare(string s, string t) {
       Stack<char> stack=new();
        string sCopy="";
        string tCopy="";
        foreach(char c in s ){
            if(c!='#'){
                stack.Push(c);
            }else{
                if(stack.Count>0)
                stack.Pop();
            }
        }
        foreach (char str in stack){
                 sCopy += str.ToString();                
            }
        
        stack.Clear();
        foreach(char c in t ){
            if(c!='#'){
                stack.Push(c);
            }else{
                if(stack.Count>0)
                stack.Pop();
            }
        }
         foreach (char str in stack){
             
                tCopy += str.ToString();
                
            }
         stack.Clear();        
        if(sCopy.Equals(tCopy)){
            return true;
        }else{
            return false;
        }
        
    }
}