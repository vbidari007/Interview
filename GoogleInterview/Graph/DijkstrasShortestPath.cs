﻿// C# Program for Dijkstra's single
// source shortest path algorithm.
// The program is for adjacency matrix
// representation of the graph
using System;
namespace Graph
{
    public class GFG
    {
        // A utility function to find the
        // vertex with minimum distance
        // value, from the set of vertices
        // not yet included in shortest
        // path tree
        static int V = 9;

        public int minDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
            {
                if(sptSet[v]==false && dist[v] <=min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }

            return min_index;
        }

        // A utility function to print
        // the constructed distance array

        public void PrintSolution(int[] dist)
        {
            Console.WriteLine("Vertex \t\t Distance from source \n");

            for (int i = 0; i < V; i++)
            {
                Console.Write(i+"\t\t" +dist[i] +"\n");
            }


        }


        // Function that implements Dijkstra's
        // single source shortest path algorithm
        // for a graph represented using adjacentry matrix
        // representation

        public void Dijkstra(int[,] graph,int src)
        {
            int[] dist = new int[V];
            // The output array. dist[i]
            // will hold the shortest  distance from
            // src to i


            //sptSet will true if vertex
            //i is inlcuded in shortest path
            //tree or shortest distance from
            // src to i is finalized
            bool[] sptSet = new bool[V];

            //initialize all distances as INFINITE
            // and SptSet as false
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            //Distnce of source vertex
            // from itself is always 0

            dist[src] = 0;

            //Find shortest path for all vertices
            for (int count = 0; count < V-1; count++)
            {
                //Pick the minimum distance vertex
                //from the set of vertices not yet
                //processed. u is always equal to
                //src in first iteration
                int u = minDistance(dist, sptSet);


                //Mark the picked vertex as processed
                sptSet[u] = true;

                //Update dist value of the adjacent
                // vertices of the picked vertex.

                for (int v = 0; v < V; v++)
                {
                    //Update dist[v] only if is not in
                    //sptSet, there is an edge from u
                    // to v, and total weight of path
                    //from src to v through u is smaller
                    // than current value of dist[v]

                    if (!sptSet[v] && graph[u, v] != 0
                        && dist[u] != int.MaxValue
                        && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
                }

                // print the constricted distance array
                PrintSolution(dist);
            }


        }
    }
}
