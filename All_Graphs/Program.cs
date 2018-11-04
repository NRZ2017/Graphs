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
            graph.ContainsLoop()
            Console.ReadKey();
        }
    }
}
