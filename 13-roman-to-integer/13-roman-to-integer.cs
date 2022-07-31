public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<string,int> dict=new Dictionary<string,int>();
        dict.Add("I",1);
        dict.Add("V",5);
        dict.Add("X",10);
        dict.Add("L",50);
        dict.Add("C",100);
        dict.Add("D",500);
        dict.Add("M",1000);
        dict.Add("IV",4);
        dict.Add("IX",9);
        dict.Add("XL",40);
        dict.Add("XC",90);
        dict.Add("CD",400);
        dict.Add("CM",900);
        
        // foreach(char c in s){
        //     string str=c.ToString();
        //     dict.ContainsKey(str);
        // }
        int result=0;
        for (int i = 0; i < s.Length; i++)
        {
            string str = s[i].ToString();
            string str2 = "";
            if (i< s.Length - 1)
            {
                str2 = str + s[i + 1].ToString();
            }
            
            if (dict.ContainsKey(str2))
            {
                result += dict[str2];
                ++i;
            }
            else
            {
                result += dict[str];
            }
        }
        return result;
    }
}