namespace Number_of_Islands
{
    public class BreadthFirstSearch
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

                        Queue<(int, int)> queue = new Queue<(int, int)>();
                        queue.Enqueue((i, j));

                        if (queue.Count > 0)
                        {
                            var (r, c) = queue.Dequeue();

                            int[][] direction = new int[][]
                            {
                                new int[]{1,0},new int[]{-1,0},new int[]{0,1},new int[]{0,-1}
                            };

                            foreach (var dir in direction)
                            {
                                int nr = r + dir[0], nc = c + dir[1];

                                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && grid[nr][nc] == '1')
                                {
                                    queue.Enqueue((nr, nc));
                                    grid[nr][nc] = '0';
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
