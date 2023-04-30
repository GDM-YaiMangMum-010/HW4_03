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

        bool count2 = true;
        while(count2 == true)
        {
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            if(i >= 0 && i < n && j >= 0 && j < n)
            {
                g.AddEdge(i,j,1);
            }
            else
            {
                count2 = false;
                icheck = j;
            }
        }
        jcheck = int.Parse(Console.ReadLine());

        bool check = true;
        if(check == true)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }

        /*
        LinkedList<int> nodeValueList = g.GetAllNode();
        for(int a=0; a<nodeValueList.GetLength(); a++)
        {
            Console.WriteLine(nodeValueList.Get(a));
        }

        
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