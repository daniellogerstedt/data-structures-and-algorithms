using System;
using Xunit;
using Graphs.Classes;
using System.Collections.Generic;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyGraph()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
        }

        [Fact]
        public void TestAddNode()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            Assert.Equal(1, graph.Vertices[0].Data);
        }

        [Fact]
        public void TestAddEdge()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdge(graph.Vertices[0], graph.Vertices[1], 10);
            Assert.Equal(10, graph.Vertices[0].Neighbors[0].Weight);
        }

        [Fact]
        public void TestGetNodes()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            graph.AddVertex(2);
            List<Vertex<int>> list = graph.GetVertices();
            Assert.Equal(2, list.Count);
        }


        [Fact]
        public void TestGetEdges()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdge(graph.Vertices[0], graph.Vertices[1], 10);
            graph.AddEdge(graph.Vertices[0], graph.Vertices[0], 5);
            List<Edge<int>> list = graph.GetEdges(graph.Vertices[0]);
            Assert.Equal(2, list.Count);
        }


        [Fact]
        public void TestGetCorrectNodes()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            graph.AddVertex(2);
            List<Vertex<int>> list = graph.GetVertices();
            Assert.Equal(2, list[1].Data);
        }

        [Fact]
        public void TestGetCorrectEdges()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Empty(graph.Vertices);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddEdge(graph.Vertices[0], graph.Vertices[1], 10);
            graph.AddEdge(graph.Vertices[0], graph.Vertices[0], 5);
            List<Edge<int>> list = graph.GetEdges(graph.Vertices[0]);
            Assert.Equal(10, list[0].Weight);
        }

    }
}
