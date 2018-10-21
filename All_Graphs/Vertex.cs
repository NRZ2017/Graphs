using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Vertex<T>
    {
       public T Value;
       public List<Vertex<T>> Edges = new List<Vertex<T>>();

        public Vertex(T value)
        {
            this.Value = value;
            Edges = new List<Vertex<T>>();
        }
    }

}
