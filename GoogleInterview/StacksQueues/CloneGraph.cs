using System;
using System.Collections.Generic;

namespace StacksQueues
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    public class CloneGraphSolution
    {
        private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

        public Node CloneGraph_DFS(Node node)
        {
            if(node==null)
            {
                return node;
            }

            if(visited.ContainsKey(node))
            {
                return visited[node];
            }

            Node cloneNode = new Node(node.val, new List<Node>());

            visited.Add(node, cloneNode);

            foreach (var n in node.neighbors)
            {
                cloneNode.neighbors.Add(CloneGraph_DFS(n));
            }

            return cloneNode;
        }

        public Node CloneGraph(Node node)
        {
            if(node==null)
            {
                return node;
            }

            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            visited.Add(node, new Node(node.val, new List<Node>()));

            while(queue.Count > 0)
            {
                Node n = queue.Dequeue();

                foreach (var neighbor in n.neighbors)
                {
                    if(!visited.ContainsKey(neighbor))
                    {
                        visited.Add(neighbor, new Node(neighbor.val, new List<Node>()));
                        queue.Enqueue(neighbor);
                    }
                    visited[n].neighbors.Add(visited[neighbor]);
                }
            }

            return visited[node];
        }
    }
}
