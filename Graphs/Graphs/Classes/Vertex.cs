using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Vertex<T>
    {

        public T Data { get; set; }
        public List<Edge<T>> Neighbors { get; set; }

    }
}
