using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Edge<T>
    {

        public Vertex<T> PointsTo { get; set; }
        public int Weight { get; set; }

    }
}
