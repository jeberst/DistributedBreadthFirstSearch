using Smrf.NodeXL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smrf.NodeXL.Layouts;
using Smrf.NodeXL.Algorithms;
using Smrf.NodeXL.GraphDataProviders.Facebook;
using System.Threading;

namespace DistributedBreadthFirstSearch
{
    public class GraphGenerator
    {
        public GraphGenerator() { }

        public void Generator()
        {
            Graph oGraph = new Graph(GraphDirectedness.Undirected);
            IVertexCollection oVertices = oGraph.Vertices;
        }

         
        public void Importer()
        {
            Smrf.NodeXL.GraphDataProviders.Facebook.FacebookGraphDataProvider fbGraph = new Smrf.NodeXL.GraphDataProviders.Facebook.FacebookGraphDataProvider();
            string data = "";
            GraphGenerator graph = new GraphGenerator();

            fbGraph.TryGetGraphData(out data);

            Console.WriteLine(data);

        }
    }
}
