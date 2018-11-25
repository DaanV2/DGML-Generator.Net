using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface INode
    {
        /// <summary>TODO</summary>
        string Label { get; set; }

        /// <summary>TODO</summary>
        string ID { get; set; }

        /// <summary>TODO</summary>
        NodeType NodeType { get; set; }
    }
}
