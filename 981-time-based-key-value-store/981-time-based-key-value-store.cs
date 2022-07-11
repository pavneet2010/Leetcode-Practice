public class TimeMap {

    Dictionary<string, List<(int, string)>> dict;
    public TimeMap() {
        dict=new Dictionary<string, List<(int, string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!dict.ContainsKey(key)){
            
            dict.Add(key, new List<(int, string)> { (timestamp, value) });
        }
        else
        {
            dict.TryGetValue(key, out var list);
            list.Add((timestamp, value));
        }        
    }
    
    public string Get(string key, int timestamp) {
        Dictionary<string, string> res = new Dictionary<string, string>();
        if(dict.ContainsKey(key)){
            string result=dict[key].LastOrDefault(k=>k.Item1<=timestamp).Item2;
        if(result==null){
            return "";
        }
        return  result;
        }
        return"";
        
    }
}