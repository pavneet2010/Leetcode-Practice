public class Solution {
    public int NumDecodings(string s) {
        return Decode(s, new Dictionary<string, int>());
    }
    private int Decode(string s, Dictionary<string, int> existing){
        if(s.Length == 0)
            return 1;       
        if(s[0] == '0')
            return 0;
        if(existing.ContainsKey(s))
            return existing[s];
        if(s.Length == 1){
            existing.Add(s, 1);
            return 1;
        }
        
        var sol = Decode(s.Remove(0, 1), existing);
        if(int.Parse(s.Substring(0, 2)) <= 26)
            sol += Decode(s.Remove(0, 2), existing);
        
        existing.Add(s, sol);
        return sol;        
    }
}