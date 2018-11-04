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
       public Dictionary<Vertex<T>,double> Edges = new Dictionary<Vertex<T>,double>(); //Dictionary<Vertex<T>, double>

        public Vertex(T value)
        {
            this.Value = value;
            Edges = new Dictionary<Vertex<T>, double>;
        }
    }

}
