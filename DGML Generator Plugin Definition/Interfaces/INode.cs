using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    ///TODO add description <summary></summary>
    public interface INode
    {
        ///TODO add description <summary></summary>
        string ID { get; set; }

        ///TODO add description <summary></summary>
        string Label { get; set; }

        ///TODO add description <summary></summary>
        NodeType NodeType { get; set; }
    }
}
