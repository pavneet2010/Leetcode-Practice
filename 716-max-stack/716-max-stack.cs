public class MaxStack {

    private Stack<int> _data { get; set; }
    private Stack<int> _max { get; set; }
    
    public MaxStack() {
        _data = new Stack<int>();
        _max = new Stack<int>();
    }
    
    public void Push(int x) {
        if (_max.Count == 0 || _max.Peek() <= x)
            _max.Push(x);
        
        _data.Push(x);
    }
    
    public int Pop() {
        var x = _data.Pop();
        if (x == _max.Peek())
            _max.Pop();
        return x;
    }
    
    public int Top() {
         return _data.Peek();
    }
    
    public int PeekMax() {
        if (_max.Count > 0)
            return _max.Peek();
        else 
            return 0;
    }
    
    public int PopMax() {
        var x = _max.Pop();
        
        var data = new Stack<int>();
        var current = _data.Pop();

        while (current != x)
        {
            data.Push(current);
            current = _data.Pop();
        }
        
        while (data.Count != 0)
        {
            Push(data.Pop());
        }
        
        return x;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */