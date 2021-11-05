using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Vertex v0 = new Vertex(0);
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3= new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);
            Vertex v6 = new Vertex(6);

            graph.AddVertex(v0);
            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);

            graph.CreateAdjList();

            graph.AddEdge(v0, v1);
            graph.AddEdge(v0, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v1, v4);
            graph.AddEdge(v1, v5);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v3, v6);
            graph.AddEdge(v4, v3);
            graph.AddEdge(v5, v6);

            graph.PrintAdjList();

            graph.DFS(v0);
            Console.ReadLine();
        }
    }
}
