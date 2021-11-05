using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
    class Graph
    {
        private List<Vertex> V = new List<Vertex>();
        private List<Edge> E = new List<Edge>();
        private List<Vertex>[] adjList;
        private bool[] visited;
        public int VertexCount => V.Count;

        public void CreateAdjList()
        {
            visited = new bool[VertexCount];
            adjList = new List<Vertex>[VertexCount];
            for (int i = 0; i < VertexCount; i++)
            {
                adjList[i] = new List<Vertex>();
            }
        }
        public void AddVertex(Vertex v)
        {
            V.Add(v);
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            adjList[from.number].Add(to);
        }
        public void PrintAdjList()
        {
            for (int i = 0; i < VertexCount; i++)
            {
                Console.Write(i + ": ");
                foreach (Vertex v in adjList[i])
                {
                    Console.Write(v.number+ ", ");
                }
                Console.WriteLine();
            }
        }
        public void DFS(Vertex vertex)
        {
            visited[vertex.number] = true;
            Console.Write(vertex.number+ "--");
            List<Vertex> tmp = adjList[vertex.number];
            foreach(Vertex v in tmp)
            {
                if (!visited[v.number])
                {
                    DFS(v);
                }
            }
        }

       
    }
}
