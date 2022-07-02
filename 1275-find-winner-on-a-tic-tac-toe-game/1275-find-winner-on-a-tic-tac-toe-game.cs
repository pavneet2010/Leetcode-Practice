public class Solution {
    int[,] arr=new int[3,3];
    public string Tictactoe(int[][] moves) {  
        if(moves.Length<5){
            return "Pending";
        }
        
        int turn=0;
        for(int i=0;i<moves.Length;i++){
            if(i%2==0){
                turn=1;
            }else{
                turn=-1;
            }
            int firstPos=moves[i][0];
            int secondPos=moves[i][1];            
            arr[firstPos,secondPos]=turn;            
          string res=  CheckIfDone();
            if(res=="A"|| res=="B"){
                return res;
            }else if(res==""&& i==8){
                return "Draw";
            }
            
            
        }
        
        
        return "Pending";
        
    }
    public string CheckIfDone(){
        
        //Check all Rows
        for(int i=0;i<3;i++){
            int colsum=0;
            int rowsum=0;
            for(int j=0;j<3;j++){
                colsum+=arr[i,j];
                rowsum+=arr[j,i];
                if(colsum==3){
                    return "A";
                }else if (colsum==-3){
                    return "B";
                }
                if(rowsum==3){
                    return "A";
                }else if (rowsum==-3){
                    return "B";
                }
            }
        }
         
        if(arr[0,0]+arr[1,1]+arr[2,2]==3){
            return "A";
        }else if(arr[0,0]+arr[1,1]+arr[2,2]==-3){
            return "B";
        }
         if(arr[2,0]+arr[1,1]+arr[0,2]==3){
            return "A";
        }else if(arr[2,0]+arr[1,1]+arr[0,2]==-3){
            return "B";
        }
        return "";   
        
        
    }
}