using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Solutions_of_Alghorithmic_problems
{
    //(Finding_the_Shortest_Path)
    public class Dijkstra_Alghorithm
    {
        public void Test()
        {
            var nodes = new Dictionary<string, Node>
            {
                
                //{ "A",new Node("A") },
                ["A"] = new Node("A"),
                ["B"] = new Node("B"),
                ["C"] = new Node("C"),
                ["D"] = new Node("D"),
                ["E"] = new Node("E"),
                ["F"] = new Node("F")
            };

            /*
                   6
                B------E
             2 /|    / |\ 9
              / |   /  | \
             A 5|  /  1|  C
              \ | /3   |  /  
             8 \|/     | / 3  
                D------F
                   2
             */

            nodes["A"].AddEdge(nodes["B"], 2).AddEdge(nodes["D"], 8);
            nodes["B"].AddEdge(nodes["A"], 2).AddEdge(nodes["D"], 5).AddEdge(nodes["E"], 6);
            nodes["C"].AddEdge(nodes["E"], 9).AddEdge(nodes["F"], 3);
            nodes["D"].AddEdge(nodes["A"], 8).AddEdge(nodes["B"], 5).AddEdge(nodes["E"], 3).AddEdge(nodes["F"], 2);
            nodes["E"].AddEdge(nodes["B"], 6).AddEdge(nodes["D"], 3).AddEdge(nodes["F"], 1).AddEdge(nodes["C"], 9);
            nodes["F"].AddEdge(nodes["C"], 3).AddEdge(nodes["D"], 2).AddEdge(nodes["E"], 1);

            var finalNode= nodes["C"];

            var pathNodes = DijkStraMethod(nodes, finalNode, out int? finalShortestDistance);

            Console.WriteLine(string.Join("->", pathNodes.Select(i=>i.Name)));
            Console.WriteLine($"Total Distance: {finalShortestDistance}");
            Console.ReadLine();
        }


         /*
                   6
                B------E
             2 /|    / |\ 9
              / |   /  | \
             A 5|  /  1|  C
              \ | /3   |  /  
             8 \|/     | / 3  
                D------F
                   2
             */
        public List<Node> DijkStraMethod(Dictionary<string, Node> nodes,Node finalNode, out int? finalShortestDistance)
        {
            var distances = nodes.ToDictionary(kvp => kvp.Value, kvp => int.MaxValue);

            var parents = new Dictionary<Node, Node>();

            var undiscoveredNodes = new HashSet<Node>(nodes.Values);

            var firstNode = distances.OrderBy(node => node.Value).First();
            distances[firstNode.Key] = 0;

            while (undiscoveredNodes.Count > 0)
            {
                //var current = undiscoveredNodes.OrderBy(node => distances[node]).First();
                var current = undiscoveredNodes.MinBy(node => distances[node]);
                undiscoveredNodes.Remove(current);
                if (current == finalNode)
                {
                    break;
                }

                foreach (var (neighborNode, distance) in current.Edges)
                {
                    var subDistance = distances[current] + distance;
                    if (subDistance < distances[neighborNode])
                    {
                        distances[neighborNode] = subDistance;
                        parents[neighborNode] = current;
                    }
                }

            }

            // Traversing the path
            var pathNodes = new List<Node>();
            var currentNode = finalNode;

            while (currentNode is not null)
            {
                pathNodes.Insert(0, currentNode);
                currentNode = parents.TryGetValue(currentNode, out var parentNode) ? parentNode : null;
            }

             finalShortestDistance = distances[finalNode];

            return pathNodes;
        }
    }

    public class Node
    {
        public string Name { get; set; }

        public Dictionary<Node, int> Edges { get; set; }

        public Node(string name)
        {
            Name = name;
        }

        public Node(string name, Dictionary<Node, int> edges)
        {
            Name = name;
            Edges = edges;
        }

        public Node AddEdge(Node node, int distance)
        {
            Edges ??= new Dictionary<Node, int>();
            Edges.Add(node,distance);
            return this;
        }

        public override string ToString()
        {
            return $"Node:{Name}, Edges:{Edges?.Count}";
        }
    }
}
