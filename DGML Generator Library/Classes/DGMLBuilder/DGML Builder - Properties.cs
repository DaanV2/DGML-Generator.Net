using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGMLGenerator.Plugin.Definition;
using ThreadSafeDictionary;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    public partial class DGMLBuilder
    {
        ThreadSafeDictionary<string, Link> Links { get; set; }
        ThreadSafeDictionary<string, Node> Nodes { get; set; }
    }
}
