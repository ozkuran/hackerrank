using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Node
{
    public Node()
    {
        Neighbours = new HashSet<int>();
        visited = false;
    }
    public Node(int nodeNumber) : this()
    {
        NodeNumber = nodeNumber;
    }
    public HashSet<int> Neighbours;
    public int NodeNumber;
    public bool visited;
}

class graphbfs
{
    static void Main(String[] args)
    {
        System.IO.StreamReader file = new System.IO.StreamReader("in.txt");
        var queryCount = Int32.Parse(file.ReadLine());
        for (var i = 0; i < queryCount; i++)
        {
            var a = file.ReadLine().Split().Select(Int32.Parse).ToList();
            int NodeCount = a[0];
            Console.WriteLine("NodeCount=" + NodeCount);
            int EdgeCount = a[1];
            Console.WriteLine("EdgeCount=" + EdgeCount);
            List<int> pathLength = Enumerable.Repeat(-1, NodeCount).ToList();
            List<Node> Nodes = new List<Node>();
            for (int k = 1; k <= NodeCount; k++)
            {
                Nodes.Add(new Node(k));
            }
            for (int j = 0; j < EdgeCount; j++)
            {
                var nodes = file.ReadLine().Split().Select(Int32.Parse).ToList();
                Nodes[nodes[0] - 1].Neighbours.Add(nodes[1]);
                Nodes[nodes[1] - 1].Neighbours.Add(nodes[0]);
            }
            Queue<int> queue = new Queue<int>();
            int startNode = Int32.Parse(file.ReadLine());
            queue.Enqueue(startNode);
            while (queue.Count > 0)
            {
                int n = queue.Dequeue();
                Nodes[n - 1].visited = true;
                Console.WriteLine("n=" + n);
                foreach (int neighbour in Nodes[n - 1].Neighbours)
                {
                    Console.WriteLine(neighbour);
                    if (!Nodes[neighbour - 1].visited)
                    {
                        if (!queue.Contains(neighbour))
                        {
                            queue.Enqueue(neighbour);
                        }
                        if (pathLength[neighbour - 1] == -1)
                        {
                            if (pathLength[n - 1] != -1)
                            {
                                pathLength[neighbour - 1] = pathLength[n - 1] + 6;
                            }
                            else
                            {
                                pathLength[neighbour - 1] = 6;
                            }
                        }
                    }
                }
            }

            List<string> distances = new List<string>();
            for (int distance = 0; distance < NodeCount; distance++)
            {
                if ((distance + 1) != startNode)
                {
                    distances.Add(pathLength[distance].ToString());
                }

            }
            Console.WriteLine(string.Join(" ", distances));
        }

        Console.ReadLine();
    }
}