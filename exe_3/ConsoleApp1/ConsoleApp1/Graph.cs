using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Graph : IEnumerable
    {
        List<Edge> edges { get; set; }
        List<Node> nodes { get; set; }

        public Graph()


        {
            edges = new();
            nodes = new();
            for (int i = 0; i < 20; i++)
            {
                nodes.Add(new Node { value = i });
            }
            
            // צור גרף קשיר ע"י חיבור ליניארי (Node0-Node1, Node1-Node2, ..., Node18-Node19)
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                edges.Add(new Edge { node1 = nodes[i], node2 = nodes[i + 1] });
            }
            Console.WriteLine(edges.Count);
        }

        public IEnumerator GetEnumerator()
        {
            return new GraphIterator(this);
        }

        class GraphIterator : IEnumerator
        {
            Graph graphToEnumerate;
            int pos = -1;
            public GraphIterator(Graph graph)
            {
                graphToEnumerate = graph;
            }

            public object Current
            {
                get
                {
                    return graphToEnumerate.edges[pos];
                }
            }


            public bool MoveNext()
            {
                pos++;
                //for (; pos < graphToEnumerate.edges.Count; pos++) ;
                if (pos < graphToEnumerate.edges.Count == false)
                {
                    Reset();
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }
        }


    }
}

