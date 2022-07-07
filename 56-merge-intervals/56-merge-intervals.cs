public class Solution {
    public int[][] Merge(int[][] intervals) {
var size = intervals.Length;
var result = new List<int[]>();

    intervals =  intervals.OrderBy(x=>x[0]).ToArray();
    
    result.Add(intervals[0]);
    for(int i=1;i < size;i++)
    {
        var prev = result[result.Count-1];
        var curr = intervals[i];
        var prev_end = prev[1];
        var curr_start = curr[0];
        if(prev_end >= curr_start)
        {
            result[result.Count-1][1] 
                =Math.Max(prev_end,curr[1]);
        }
        else
        {
           result.Add(curr); 
        };
    }      
    return result.ToArray();     
}
}