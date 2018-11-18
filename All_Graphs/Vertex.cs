using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Graphs
{
    class Vertex<T> : IComparable<Vertex<T>> where T : IComparable<T> 
    {
        public T Value;

        public bool IsVisited = false;
        public double TotalDistance = double.PositiveInfinity;
        public Vertex<T> Founder = null;

        public Dictionary<Vertex<T>, double> Edges = new Dictionary<Vertex<T>, double>(); //Dictionary<Vertex<T>, double>

        public Vertex(T value)
        {
            this.Value = value;
            Edges = new Dictionary<Vertex<T>, double>();
        }

        public int CompareTo(Vertex<T> other)
        {
            return TotalDistance.CompareTo(other.TotalDistance);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

}
