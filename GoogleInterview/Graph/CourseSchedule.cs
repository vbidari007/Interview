using System;
using System.Collections.Generic;

namespace Graph
{
    public class Edge
    {
        public int Src { get; set; }
        public int Dst { get; set; }

        public Edge(int src,int dst)
        {
            Src = src;
            Dst = dst;
        }
    }

    public class Graph
    {
        public List<List<int>> adjList = null;
        public Graph(List<Edge> edges,int n)
        {
            adjList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                adjList.Add( new List<int>());
            }

            foreach (var edge in edges)
            {
                var src = edge.Src;
                var dest = edge.Dst;

                adjList[src].Add(dest);
               // adjList[dest].Add(src);
            }
        }
    }
    public class GraphSolution
    {
        public static int WHITE = 1, GRAY = 2, BLACK = 3;
        public bool IsPossible ;

        Dictionary<int, int> color;
        Dictionary<int, List<int>> adjList;
        List<int> topologicalOrder;

        private void init(int numCourses)
        {
            IsPossible = true;
            color = new Dictionary<int, int>();
            adjList = new Dictionary<int, List<int>>();
            topologicalOrder = new List<int>();

            for (int i = 0; i < numCourses; i++)
            {
                color.Add(i, WHITE);
                adjList.Add(i, new List<int>());
            }
        }

        public void DFS(int node)
        {
            if (!IsPossible)
                return;

            color[node] = GRAY;


            foreach (var neighbor in adjList[node])
            {
                if(color[neighbor] ==WHITE)
                {
                    DFS(neighbor);
                }
                else if(color[neighbor]==GRAY)
                {
                    IsPossible = false;
                }
            }

            color[node] = BLACK;
            topologicalOrder.Add(node);
        }
        public int[] FindOrder2(int numCourses, int[][] prerequisites)
        {

            init(numCourses);

            for (int i = 0; i < prerequisites.Length; i++)
            {
                int dest = prerequisites[i][0];
                int src = prerequisites[i][1];
                adjList[src].Add(dest);

            }

            for (int i = 0; i < numCourses; i++)
            {
                if(color[i]==WHITE)
                {
                    DFS(i);
                }
            }

            int[] order;
            if(IsPossible)
            {
                order = new int[numCourses];
                for (int i = 0; i < numCourses; i++)
                {
                    order[i] = topologicalOrder[numCourses - i - 1];
                }
            }
            else
            {
                order = new int[0];
            }

            return order;
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {

            bool possible = true;
            Dictionary<int, List<int>> adjList2 = new Dictionary<int, List<int>>();
            int[] InDegree = new int[numCourses];
            int[] topo = new int[numCourses];

            for (int k = 0; k < prerequisites.Length; k++)
            {
                int des = prerequisites[k][0];
                int src = prerequisites[k][1];
                adjList.Add(k, new List<int>());
                adjList[k].Add(des);
                InDegree[des] += 1;
            }


            Queue<int> queue = new Queue<int>();

            for (int k = 0; k < numCourses; k++)
            {
                if(InDegree[k]==0)

                {
                    queue.Enqueue(k);
                      
                }

            }
            int i = 0;
            while(queue.Count > 0)
            {
                int node = queue.Dequeue();
                topologicalOrder[i++] = node;
                if (adjList2.ContainsKey(node))
                {
                    foreach (var item in adjList2[node])
                    {
                        InDegree[item]--;
                    }

                    if(InDegree[node]==0)

                    {
                        queue.Enqueue(node);
                    }
                }

            }

            if (i == numCourses)
                return topologicalOrder.ToArray();
            else
                return new int[0];
        }
        }
}
