using System;

class Program
{
    static void Main(string[] args)
    {
        int i,j,icheck,jcheck;
        int n = int.Parse(Console.ReadLine());
        Graph<int> g = new Graph<int>();
        for (int count1 = 0; count1 < n; count1++)
        {
            g.AddNode(count1);
        }

        for (int count2 = 2; count2 != 1; count2++)
        {
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            if(0 < i || i < n-1 && 0 < j || j < n-1)
            {
                g.AddEdge(i,j,1);
                
            }
            else
            {
                count2 = 1;
            }
        }
        Console.WriteLine(g.GetNodeCount());
        icheck = int.Parse(Console.ReadLine());
        jcheck = int.Parse(Console.ReadLine());

        for(int o=0; o<g.GetNodeCount(); o++)
        {
            Console.WriteLine(g.GetNode(o));
        }

        /*
        g.AddNode("A");
        g.AddNode("B");
        g.AddNode("C");
        g.InsertNode(2, "D");
        g.AddEdge(0, 1, 1);
        g.AddEdge(0, 3, 1);
        g.AddEdge(1, 2, 1);
        g.AddEdge(3, 2, 1);
        g.RemoveNode(1);


        Console.WriteLine("Part 1: ");
        for(int i=0; i<g.GetNodeCount(); i++)
        {
            Console.WriteLine(g.GetNode(i));
        }

        Console.WriteLine("Part 2: ");
        LinkedList<string> nodeValueList = g.GetAllNode();
        for(int i=0; i<nodeValueList.GetLength(); i++)
        {
            Console.WriteLine(nodeValueList.Get(i));
        }
        */
    }
}