using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    interface IGraph
    {
        GraphType GraphType { get; set; }

        void AddEdge(int vertex1, int vertex2);

        List<int> GetAdjacentVerices(int vertex);
    }
}
