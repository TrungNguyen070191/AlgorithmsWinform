using AlgorithmsApplication.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsApplication.Utilities
{
    public class Graph
    {
        //total no of vertices
        private int Vertices;
        private int SpecifileVertices;
        //adjency list array for all vertices.
        private List<Int32>[] adj;
        /* Example : vertices=4
         *      0->[1,2]
         *      1->[2]
         *      2->[0,3]
         *      3->[]
         */

        //constructor
        public Graph(int v, int s)
        {
            Vertices = v;
            SpecifileVertices = s;
            adj = new List<Int32>[v];
            //Instantiate adjacecny list for all vertices
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }

        }

        //Add edge from v->w
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        //Print BFS traversal
        //s-> start node
        //BFS uses queue as a base.
        public Int32[] BFS()
        {
            Int32[] mang = new Int32[1000];
            int j = 0;
            int s = SpecifileVertices;
            bool[] visited = new bool[Vertices];

            //create queue for BFS
            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            //loop through all nodes in queue
            while (queue.Count != 0)
            {
                //Deque a vertex from queue and print it.
                s = queue.Dequeue();
                
                mang[j] = s;
                j++;
                Console.WriteLine("next->" + s);

                //Get all adjacent vertices of s
                foreach (Int32 next in adj[s])
                {
                    if (!visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }

            }
            Globalgraph.len = j;
            return mang;
        }

        //DFS traversal 
        // DFS uses stack as a base.
        public Int32[] DFS()
        {
            Int32[] mang = new Int32[1000];
            int j=0;
            bool[] visited = new bool[Vertices];
            int s = SpecifileVertices;
            //For DFS use stack
            Stack<int> stack = new Stack<int>();
            visited[s] = true;
            stack.Push(s);
            
            while (stack.Count != 0)
            {
                s = stack.Pop();
                mang[j] = s;
                j++;
                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                    }
                }
            }
            Globalgraph.len = j;
           return mang;
        }

        public void PrintAdjacecnyMatrix()
        {
            for (int i = 0; i < Vertices; i++)
            {
                Console.Write(i + ":[");
                string s = "";
                foreach (var k in adj[i])
                {
                    s = s + (k + ",");
                }
                s = s.Substring(0, s.Length - 1);
                s = s + "]";
                Console.Write(s);
                Console.WriteLine();
            }
        }
    }
}
