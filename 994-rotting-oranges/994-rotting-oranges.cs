public class Solution {
    public int OrangesRotting(int[][] grid) {  
        var EMPTY = 0;
        var FRESH = 1;
        var ROTTEN = 2;
        
        var elapsed = 0;
        var freshCount = 0;
        var queue = new Queue<KeyValuePair<int, int>>();
        
        // Get fresh cell count and rotten cell coordinates
        for (int row = 0; row < grid.Length; ++row) {
            for (int col = 0; col < grid[row].Length; ++col) {
                if (grid[row][col] == FRESH) {
                    ++freshCount;
                } else if (grid[row][col] == ROTTEN) {
                    queue.Enqueue(new KeyValuePair<int, int>(row, col));
                }                
            }          
        }
        
        // Search directions
        var directions = new List<KeyValuePair<int, int>>() {
            // Right
            new KeyValuePair<int, int>(0, 1),
            // Left
            new KeyValuePair<int, int>(0, -1),
            // Top
            new KeyValuePair<int, int>(-1, 0),
            // Bottom
            new KeyValuePair<int, int>(1, 0),
        };
        
        // Look for fresh cells to turn rotten		
        while (queue.Count > 0) {            
            for (int itemCount = queue.Count; itemCount > 0; --itemCount) {
                var current = queue.Peek();
                queue.Dequeue();
                
                // Get the coordinates of the rotten cell
                var row = current.Key;
                var col = current.Value;
                
                // Search right, left, top, bottom to see if a fresh cell can become rotton
                foreach (var direction in directions) {
                    var newRow = row + direction.Key;
                    var newCol = col + direction.Value;
                    
                    // If the cell is fresh in this direction, make it rotten
                    if (IsValidCell(grid, newRow, newCol) && grid[newRow][newCol] == FRESH) {
                        grid[newRow][newCol] = ROTTEN;
                        queue.Enqueue(new KeyValuePair<int, int>(newRow, newCol));
                        --freshCount;                        
                    }
                }       
            }
            
            // Increment elapsed time
            if (queue.Count > 0) {
                ++elapsed;
            }
        }
        
        return freshCount > 0 ? -1 : elapsed;
    }
    
    private bool IsValidCell(int[][] grid, int row, int col) {
        return row >= 0 && row < grid.Length && col >= 0 && col < grid[row].Length;
    }
}