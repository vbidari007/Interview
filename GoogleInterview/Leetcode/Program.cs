﻿using System;
using System.Collections.Generic;
//using HashTable;
using LinkedList;
using StacksQueues;
using Heap;
using Graph;
namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Let us create the example
 graph discussed above */
            int[,] graph
                = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                            { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            GFG t = new GFG();

            // Function call
            t.Dijkstra(graph, 0);
            Console.WriteLine("Hello World!");
        }
    }

   
}
