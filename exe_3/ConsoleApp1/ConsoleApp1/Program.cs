using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        
        List<int> ints = new List<int>();

        Graph g = new Graph();
        int i = 0;
        Console.WriteLine("============");
        foreach (Edge item in g)
        {
            
            Console.WriteLine(item.node1.value+"->"+item.node2.value);
           
        }
    }
}