public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int i=0;
        while(arr[i]<arr[i+1])i++;
        return i;
    }
}