//// <copyright file="AdjacencyGraphFactory.cs" company="MSIT">Copyright © MSIT 2007</copyright>

//namespace QuickGraph
//{
//    using System.Collections.Generic;

//    public static class AdjacencyGraphFactory
//    {
//        [PexFactoryMethod(typeof(AdjacencyGraph<int, Edge<int>>))]
//        public static AdjacencyGraph<int, Edge<int>> Create(
//            bool allowParralelEdges,
//            KeyValuePair<int, int>[] edges)
//        {
//            PexAssume.NotNull(edges);

//            var adjacencyGraph
//                = new AdjacencyGraph<int, Edge<int>>(allowParralelEdges);
//            if (edges != null && edges.Length <= 3)
//            {
//                foreach (var edge in edges)
//                    adjacencyGraph.AddVerticesAndEdge(new Edge<int>(edge.Key, edge.Value));
//            }

//            return adjacencyGraph;
//        }
//    }
//}