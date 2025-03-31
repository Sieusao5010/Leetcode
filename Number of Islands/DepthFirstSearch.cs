
public class DepthFirstSearch
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    DFS(grid, i, j);
                }
            }
        }
        return count;
    }

    private void DFS(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';

        DFS(grid, i + 1, j); // top
        DFS(grid, i - 1, j); // bottom
        DFS(grid, i, j + 1); // left
        DFS(grid, i, j - 1); // right
    }
}