public class MyHashMap {
    Dictionary<int,int> dict=new Dictionary<int,int> ();

    public MyHashMap() {
        
    }
    
    public void Put(int key, int value) {
       if(!dict.ContainsKey(key)) {
           dict.Add(key,value);
       }else{
           dict[key]=value;
       }
    }
    
    public int Get(int key) {
        if(dict.ContainsKey(key)) {
           return dict[key];
       }else{
           return -1;
       }
    }
    
    public void Remove(int key) {
        dict.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */