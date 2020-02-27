using System;
using System.Collections.Generic;

namespace GraphDs
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new GraphDataStructure(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            

            graph.Dfs(1);
            Console.WriteLine(graph.IsCyclic());
            

            var g = new GraphDataStructure(4);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            graph.Bfs(2);


            var gra = new GraphD(9);
            gra.AddEdge(0, 1, 4);
            gra.AddEdge(0, 7, 8);
            gra.AddEdge(1, 2, 8);
            gra.AddEdge(1, 7, 11);
            gra.AddEdge(2, 3, 7);
            gra.AddEdge(2, 8, 2);
            gra.AddEdge(2, 5, 4);
            gra.AddEdge(3, 4, 9);
            gra.AddEdge(3, 5, 14);
            gra.AddEdge(4, 5, 10);
            gra.AddEdge(5, 6, 2);
            gra.AddEdge(6, 7, 1);
            gra.AddEdge(6, 8, 6);
            gra.AddEdge(7, 8, 7);

            gra.PrintGraph();
            gra.Dijkstra(0);
            Console.WriteLine("Prim");
            gra.Prim(0);



        }
    }

    public class GraphD
    {
        private readonly int V;
        private int[,] adj;

        public GraphD(int v)
        {
            V = v;
            adj = new int[V,V];

            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    adj[i, j] = 0;
                }
            }
        }

        public void PrintGraph()
        {
            for (int u = 0; u < V; u++)
            {
                for (int v = 0; v < V; v++)
                {
                    Console.Write(adj[u, v] + " ");
                }

                Console.WriteLine();
            }
        }

        public void AddEdge(int u, int v, int w)
        {
            adj[u, v] = w;
            adj[v, u] = w;
        }

        public void Dijkstra(int src)
        {
            var inSet = new bool[V];
            var dist = new int[V];

            for (int i = 0; i < V; i++)
            {
                inSet[i] = false;
                dist[i] = int.MaxValue;
            }

            dist[src] = 0;

            for (int i = 0; i < V - 1; i++)
            {
                int u = MinimumDistance(dist, inSet);
                inSet[u] = true;

                for (int j = 0; j < V; j++)
                {
                    if (inSet[j] == false && adj[u, j] != 0 && dist[u] != int.MaxValue && dist[j] > dist[u] + adj[u, j])
                    {
                        dist[j] = dist[u] + adj[u, j];
                    }
                }
            }


            for (int i = 0; i < V; i++)
            {
                Console.WriteLine(src + " --> " + i + " : " + dist[i]);
            }
        }

        public void Prim(int src)
        {
            var inMstSet = new bool[V];
            var key = new int[V];
            var parent = new int[V];

            for (int i = 0; i < V; i++)
            {
                parent[i] = -1;
                key[i] = int.MaxValue;
                inMstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int i = 0; i < V - 1; i++)
            {
                int u = MinimumDistance(key, inMstSet);
                inMstSet[u] = true;
                for (int v = 0; v < V; v++)
                {
                    if (!inMstSet[v] && adj[u, v] != 0 && key[u] != int.MaxValue && key[v] > adj[u, v])
                    {
                        key[v] = adj[u, v];
                        parent[v] = u;
                    }
                }
            }

            for (int i = 0; i < V; i++)
            {
                Console.WriteLine(i + "-->" + parent[i] + " : " + key[i]);
            }


        }

        private int MinimumDistance(int[] dist, bool[] inSet)
        {
            int minIndex = 0;
            int min = int.MaxValue;
            for (int i = 0; i < V; i++)
            {
                if (!inSet[i] && dist[i] < min)
                {
                    min = dist[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }

    public class GraphDataStructure
    {
        private readonly int V;
        private readonly List<List<int>> _adj;

        public GraphDataStructure(int v)
        {
            V = v;
            _adj = new List<List<int>>(V);
            for(int i = 0; i < V; i++)
                _adj.Add(new List<int>());
        }

        public void AddEdge(int u, int v)
        {
            _adj[u].Add(v);
            //_adj[v].Add(u); => Directed graph
        }

        public void Dfs(int src)
        {
            var visited = new List<bool>(V);
            for (int i = 0; i < V; i++)
                visited.Add(false);

            DfsUtil(src, visited);

            Console.WriteLine();
        }

        public void Bfs(int src)
        {
            var visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            var q = new Queue<int>(V);

            q.Enqueue(src);
            visited[src] = true;

            while (q.Count > 0)
            {
                src = q.Peek();
                q.Dequeue();
                Console.Write(src + " ");

                foreach (var v in _adj[src])
                {
                    if (!visited[v])
                    {
                        
                        visited[v] = true;
                        q.Enqueue(v);
                    }
                }
            }

            Console.WriteLine();
        }

        

        public bool IsCyclic()
        {
            var visited = new bool[V];
            var recStack = new bool[V];
            for (int i = 0; i < V; i++)
            {
                visited[i] = (false);
                recStack[i] = (false);
            }

            for (int i = 0; i < V; i++)
            {
                if (visited[i] == false)
                    if (IsCycle(i, visited, recStack))
                        return true;
            }

            return false;
        }

        private bool IsCycle(int u, bool[] visited, bool[] recStack)
        {
            if (recStack[u])
                return true;

            if (visited[u])
                return false;

            recStack[u] = visited[u] = true;

            foreach (var v in _adj[u])
            {
                if (IsCycle(v, visited, recStack))
                    return true;
            }

            recStack[u] = false;

            return false;
        }

        private void DfsUtil(int u, List<bool> visited)
        {
            visited[u] = true;
            Console.Write(u + " ");
            foreach (var v in _adj[u])
            {
                if (visited[v] == false)
                {
                    DfsUtil(v, visited);
                }
            }
        }

    }
}
