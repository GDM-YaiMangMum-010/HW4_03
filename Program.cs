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
    }
}