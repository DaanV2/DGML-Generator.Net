using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    public interface ILink
    {
        ///TODO add description <summary></summary>
        string Label { get; set; }

        ///TODO add description <summary></summary>
        LinkType LinkType { get; set; }

        ///TODO add description <summary></summary>
        string ID { get; set; }

        ///TODO add description <summary></summary>
        string IDNode1 { get; set; }

        ///TODO add description <summary></summary>
        string IDNode2 { get; set; }
    }
}
