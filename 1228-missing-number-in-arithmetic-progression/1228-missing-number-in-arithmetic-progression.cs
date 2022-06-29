public class Solution {
    public int MissingNumber(int[] arr) {
        
        int d=(arr[arr.Length-1]-arr[0])/arr.Length;

        Console.Write(d);
       for(int i=0;i<arr.Length-1;i++){            
            
            if(arr[i+1]-arr[i]!=d){
                return arr[i]+d;
            }
        }
        Console.Write(d);
        return arr[0]+d;
    }
}