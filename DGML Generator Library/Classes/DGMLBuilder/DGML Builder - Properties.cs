using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGMLGenerator.Plugin.Definition;
using ThreadSafeDictionary;

namespace DGMLGenerator
{
    public partial class DGMLBuilder
    {
        ///TODO add description <summary></summary>
        public ThreadSafeDictionary<string, Link> Links { get; set; }

        ///TODO add description <summary></summary>
        public ThreadSafeDictionary<string, Node> Nodes { get; set; }
    }
}
