using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    public class Graph<T>
    {

        public List<Vertex<T>> Vertices { get; set; }

        public Graph()
        {
            Vertices = new List<Vertex<T>>();
        }

        public void AddVertex(T Data)
        {
            Vertex<T> vertex = new Vertex<T> { Data = Data, Neighbors = new List<Edge<T>>() };
            Vertices.Add(vertex);
        }

        public void AddEdge(Vertex<T> from, Vertex<T> to, int weight)
        {
            Edge<T> edge = new Edge<T> { PointsTo = to, Weight = weight };
            from.Neighbors.Add(edge);
        }

        public List<Vertex<T>> GetVertices()
        {
            return Vertices;
        }

        public List<Edge<T>> GetEdges(Vertex<T> vertex)
        {
            return vertex.Neighbors;
        }

        public int GetSize()
        {
            return Vertices.Count;
        }

    }


}
