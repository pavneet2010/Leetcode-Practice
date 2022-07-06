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
        Console.WriteLine(sCopy);
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
        Console.WriteLine(sCopy+"-"+tCopy);
        if(sCopy.Equals(tCopy)){
            return true;
        }else{
            return false;
        }
        
    }
}