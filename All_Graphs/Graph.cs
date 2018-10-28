using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Graph<T>
    {
        public List<Vertex<T>> Vertices = new List<Vertex<T>>();
        public int EdgeCount { get; private set; }

        public Graph()
        {
        }

        public void AddVertex(Vertex<T> vert)
        {
            Vertices.Add(vert); 
        }

        public bool RemoveVertex(Vertex<T> vertex)
        {
            foreach(var vert in Vertices)
            {
                vert.Edges.Remove(vertex);
            }
            return Vertices.Remove(vertex);
        }

        public void AddEdge(Vertex<T> A, Vertex<T> B)
        {
            A.Edges.Add(B);
            B.Edges.Add(A);
        }
        public void AddDirectedEdge(Vertex<T> start, Vertex<T> end)
        {
            start.Edges.Add(end);
        }
        public Vertex<T> GetVertex(T value)
        {
            foreach(var vert in Vertices)
            {
                if (vert.Value.Equals(value))
                {
                    return vert;
                }
            }
            return null;
        }
        public void RemoveEdge(Vertex<T> A, Vertex<T> B)
        {
            A.Edges.Remove(B);
            B.Edges.Remove(A);
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
