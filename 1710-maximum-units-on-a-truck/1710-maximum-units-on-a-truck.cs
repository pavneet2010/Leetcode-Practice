public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
     PriorityQueue<int,int> q=new ();
        int sum=0;
        foreach(int[] arr in boxTypes){
            q.Enqueue(arr[0],-arr[1]);
        }
       // Console.Write("Test");
        while(truckSize>0 && q.Count>0){
          var rescord= q.TryDequeue(out int item, out int priority);
           if(item<truckSize) {
               sum+=Math.Abs(item*priority);
           }else{
               sum+=Math.Abs(truckSize*priority);
           }
            truckSize-=item;
            
        }
       
        return sum;
    }
}