using Number_of_Islands;

public class Program
{
    static void Main()
    {
        Console.WriteLine("DFS: ");
        char[][] grid1 = new char[][] {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '1', '0'}
        };

        DepthFirstSearch dfs = new DepthFirstSearch();
        int count1 = dfs.NumIslands(grid1);
        Console.WriteLine("Tìm kiếm số hòn đảo theo DFS: " + count1);

        Console.WriteLine("BFS: ");
        char[][] grid2 = new char[][] {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '1', '0'}
        };
        BreadthFirstSearch bfs = new BreadthFirstSearch();
        int count2 = bfs.NumIslands(grid2);
        Console.WriteLine("Tìm kiếm số hòn đảo theo BFS: " + count2);
    }
}