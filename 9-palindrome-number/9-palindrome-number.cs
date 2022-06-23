public class Solution {
    public bool IsPalindrome(int x) {
        int temp1=x;
        if(x<=0){
            if(x==0){
            return true;
        }
            else{
                 return false;
            }           
        }
        int temp=0;
        while(x>0){            
            temp= temp*10+x%10;
            x/=10;            
        }
        Console.Write(temp);
        if(temp==temp1){
            return true;
        }else{
            return false;
        }
        
    }
}