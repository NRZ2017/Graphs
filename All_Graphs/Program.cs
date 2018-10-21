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

            Graph<int> graph = new Graph<int>();
            List<Vertex<int>> verts = new List<Vertex<int>>();
            for(int i = 0; i < 10; i++)
            {
                graph.AddVertex(new Vertex<int>(i));
            }

            bool orphan;
            do
            {
                orphan = false;
                graph.AddEdge(graph.GetVertex(gen.Next(0, size)), graph.GetVertex(gen.Next(0, size)));
            } while()
        }
    }
}
