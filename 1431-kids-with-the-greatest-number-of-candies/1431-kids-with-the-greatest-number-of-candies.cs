public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> lst=new List<bool>();
        
        int max=0;
        foreach(int i in candies){
            if(i>max){
                max=i;
            }
        }
        foreach(int i in candies){
            int sum=extraCandies+i;
            if(sum>=max){
                lst.Add(true);
            }else{
                lst.Add(false); 
            }
                       
        }
        return lst;
    }
}