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


            Graph<string> graph = new Graph<string>();
            graph.AddVertex(new Vertex<string>("LAX"));
            graph.AddVertex(new Vertex<string>("LAS"));
            graph.AddVertex(new Vertex<string>("PHX"));
            graph.AddVertex(new Vertex<string>("DEN"));
            graph.AddVertex(new Vertex<string>("ORD"));
            graph.AddVertex(new Vertex<string>("DFW"));
            graph.AddVertex(new Vertex<string>("HOU"));
            graph.AddVertex(new Vertex<string>("ATL"));
            graph.AddVertex(new Vertex<string>("MCO"));
            graph.AddVertex(new Vertex<string>("JFK"));

            graph.AddEdge("LAX", "LAS", 1);
            graph.AddEdge("LAX", "PHX", 1);

            graph.AddEdge("LAS", "PHX", 1);
            graph.AddEdge("LAS", "DEN", 2);

            graph.AddEdge("PHX", "DFW", 1);
            graph.AddEdge("PHX", "DEN", 2);
            graph.AddEdge("PHX", "ORD", 3);

            graph.AddEdge("DFW", "HOU", 1);
            graph.AddEdge("DFW", "ORD", 3);

            graph.AddEdge("HOU", "ATL", 2);
            graph.AddEdge("HOU", "MCO", 3);
            graph.AddEdge("HOU", "ORD", 3);


            graph.AddEdge("DEN", "ORD", 3);

            graph.AddEdge("ORD", "JFK", 3);
            graph.AddEdge("ORD", "ATL", 3);

            graph.AddEdge("ATL", "MCO", 2);
            graph.AddEdge("ATL", "JFK", 3);

            graph.AddEdge("MCO", "JFK", 3);
            


            List<Vertex<string>> path = graph.FastestPath(graph.GetVertex("LAX"), graph.GetVertex("JFK")).ToList();

            for(int i = 0; i < path.Count; i++)
            {
                Console.WriteLine($"{path[i]}");
            }
            
            Console.ReadKey();
        }
    }
}
