using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Graph<T> where T : IComparable<T>
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
            foreach (var vert in Vertices)
            {
                vert.Edges.Remove(vertex);
            }
            return Vertices.Remove(vertex);
        }

        public void AddEdge(T a, T b, double weight)
        {
            //find the vertex with value a and b;
            var x = GetVertex(a);
            var y = GetVertex(b);

            if(x == null || y == null)
            {
                throw new Exception("verticies not found");
            }

            AddEdge(x, y, weight);
        }

        public void AddEdge(Vertex<T> a, Vertex<T> b, double weight)
        {
            a.Edges.Add(b, weight);
            b.Edges.Add(a, weight);
        }
        public void AddDirectedEdge(Vertex<T> start, Vertex<T> end, double weight)
        {
            start.Edges.Add(end, weight);
        }
        public Vertex<T> GetVertex(T value)
        {
            foreach (var vert in Vertices)
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

        public bool ContainsLoop(Vertex<T> start)
        {
            // Depth First Search
            Stack<Vertex<T>> stack = new Stack<Vertex<T>>();
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            stack.Push(Vertices[0]);
            while (stack.Count != 0)
            {
                Vertex<T> curr = stack.Pop();
                visited.Add(curr);
                foreach (Vertex<T> neighbor in curr.Edges.Keys)
                {
                    //if the neighbor is within the stack already, a loop exists
                    if (stack.Contains(neighbor))
                    {
                        return true;
                    }

                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }
            return false;
        }

        public IEnumerable<Vertex<T>> FastestPath(Vertex<T> start, Vertex<T> end)
        {
            //intiliaze the variables
            for(int i = 0; i < Vertices.Count; i++)
            {
                Vertices[i].IsVisited = false;
                Vertices[i].TotalDistance = double.PositiveInfinity;
                Vertices[i].Founder = null;
            }

            start.TotalDistance = 0;
            PriorityQueue<Vertex<T>> queue = new PriorityQueue<Vertex<T>>();
            queue.Insert(start);

            while(queue.Count != 0)
            {
                var current = queue.Pop();
                current.IsVisited = true;

                //loop through curr neighbors
                foreach (var edge in current.Edges)
                {
                    int tent = (int)(current.TotalDistance + edge.Value);
                    if(tent < edge.Key.TotalDistance)
                    {
                        edge.Key.TotalDistance = tent;
                        edge.Key.Founder = current;
                        edge.Key.IsVisited = false;   
                    }

                    if (!edge.Key.IsVisited && !queue.Contains(edge.Key))
                    {
                        queue.Insert(edge.Key);
                    }
                }
            }

            if(end.Founder == null)
            {
                return null;
            }

            
            List<Vertex<T>> path = new List<Vertex<T>>();
            var curr = end;
            while(curr != null)
            {
                path.Add(curr);
                curr = curr.Founder;
            }

            //keep adding founders until 

            path.Reverse();
            return path;
        }


    }
}
