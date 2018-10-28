using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int size = 10;

            //create 10 verticies
            //create 15 random edges

            //Check if the graph contains a loop
            // Stack Method: push start, push first available neighbor, pop if no neighbors available
            // Queue Method: queue start, queue neighbors, remove current


            Graph<int> graph = new Graph<int>();
            List<Vertex<int>> verts = new List<Vertex<int>>();
            for(int i = 0; i < 10; i++)
            {
                graph.AddVertex(new Vertex<int>(i));
            }
            
            for (int i = 0; i < 15; i++)
            {
                graph.AddEdge(new Vertex<int>(i), new Vertex<int>(i));
            }


            // Depth First Search
            Stack<Vertex<int>> stack = new Stack<Vertex<int>>();
            HashSet<Vertex<int>> visited = new HashSet<Vertex<int>>();
            stack.Push(graph.Vertices[0]);
            while(stack.Count != 0)
            {
                Vertex<int> curr = stack.Pop();
                visited.Add(curr);
                for (int i = 0; i < curr.Edges.Count; i++)
                {
                    if (!visited.Contains(curr.Edges[i]))
                    {
                        stack.Push(curr.Edges[i]);
                    }
                }
            }

            // Breadth First Search: Queue
            // determine if the graph has a cycle




        }
    }
}
