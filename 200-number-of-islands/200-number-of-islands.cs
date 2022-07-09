public class Solution {
    
    public void MarkNeighbours(char[][] grid,int row, int col){
        
        if(row<0|| col<0 || row>=grid.Length|| col>=grid[0].Length || grid[row][col]!='1')return ;
        grid[row][col]='2';
        MarkNeighbours(grid,row+1,col);//down
        MarkNeighbours(grid,row-1,col);//up
        MarkNeighbours(grid,row,col+1);//right
         MarkNeighbours(grid,row,col-1);//left
        
    }
    public int NumIslands(char[][] grid) {
        
        int numOfIsland=0;
        if(grid.Length==0){
            return 0;
        }
        // int rows=grid.Length;
        // int col=grid[0].Length;
       // Console.Write(rows+"-"+col);
        for(int i=0;i<grid.Length;i++){
            
            for(int j=0;j<grid[0].Length;j++){
                
                if(grid[i][j]=='1'){
                    numOfIsland++;
                    
                    MarkNeighbours(grid,i,j);
                }
                
            }
        }
        
        
        
        
        return numOfIsland;
        
    }
}