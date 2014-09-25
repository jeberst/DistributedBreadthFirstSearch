using Smrf.NodeXL.Core;
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
            GraphGenerator graphGenerator = new GraphGenerator();
            var graph = graphGenerator.Generator();

            String[] metadataCollection = graph.GetRequiredValue(ReservedMetadataKeys.AllVertexMetadataKeys, typeof(String[])) as String[];
            List<string> vertexExampleValues = new List<string>();

            foreach (var metadata in metadataCollection)
            {
                if (graph.Vertices.FirstOrDefault().GetValue(metadata.ToString()) != null)
                {
                    vertexExampleValues.Add(graph.Vertices.FirstOrDefault().GetValue(metadata.ToString()).ToString());
                }
            }

            var ShowTheExamples = vertexExampleValues;
        }
    }
}
