using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Graph<T> where T : IComparable
    {

        List<Vertex<T>> Vertices = new List<Vertex<T>>();
        List<Edge<T>> Edges = new List<Edge<T>>();

        public Graph()
        {
        }
        void DepthFirstTraversal(Vertex<T> start)
        {
            throw new NotImplementedException();
        }
        void BreadthFirstTraversal(Vertex<T> start)
        {
            throw new NotImplementedException();
        }
    }
}
