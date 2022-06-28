public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        
        
        int length = intervals.Length;
        PriorityQueue<int[], int> pq = new();
        Array.Sort(intervals, (a,b)=>{ return a[0] - b[0]; });
        
        for(int i = 0; i<length; i++){ // O(N)
            int start = intervals[i][0];
            int end = intervals[i][1];
            if(pq.Count > 0){
                var room = pq.Peek();
                if(room[1]<=start){
                    pq.Dequeue();
                }
                pq.Enqueue(intervals[i],end);  // O(log N)
            }else{
                pq.Enqueue(intervals[i], end);
            }
            
        }
        
        return pq.Count;
    }
}