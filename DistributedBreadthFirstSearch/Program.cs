using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedBreadthFirstSearch
{
    class Program
    {
         [STAThread]
        static void Main(string[] args)
        {
            GraphGenerator graph = new GraphGenerator();
            graph.Importer();
        }
    }
}
