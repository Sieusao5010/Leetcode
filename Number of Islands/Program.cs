public class Program
{
    static void Main()
    {
        char[][] grid = new char[][] {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '1', '0'}
        };

        DepthFirstSearch dfs = new DepthFirstSearch();
        int count1 = dfs.NumIslands(grid);
        Console.WriteLine("Tìm kiếm số hòn đảo theo DFS: " + count1);
    }
}