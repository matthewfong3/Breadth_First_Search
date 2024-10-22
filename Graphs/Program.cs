using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();

            Console.WriteLine("Depth First Search: ");
            myGraph.DepthFirst("Living Room");
            Console.WriteLine();
            Console.WriteLine("Breadth First Search: ");
            myGraph.BreadthFirst("Living Room");
        }
    }
}
