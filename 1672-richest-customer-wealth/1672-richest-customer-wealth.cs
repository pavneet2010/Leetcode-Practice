public class Solution {
    public int MaximumWealth(int[][] accounts) {
        //if(accounts.Length==0) return 
        int count=0,temp=0;
        foreach(int[] i in  accounts){
            int sum=0;
            for(int j=0;j<i.Length;j++){
                sum+=accounts[count][j];
            }
            temp=sum>=temp?sum:temp;
             count++;
        }
       
        return temp;
    }
}