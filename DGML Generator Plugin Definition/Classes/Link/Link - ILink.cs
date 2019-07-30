using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    public partial class Link : ILink
    {
        ///TODO add description <summary></summary>
        public string Label { get; set; }

        ///TODO add description <summary></summary>
        public LinkType LinkType { get; set; }

        ///TODO add description <summary></summary>
        public string ID { get; set; }

        ///TODO add description <summary></summary>
        public string IDNode1 { get; set; }

        ///TODO add description <summary></summary>
        public string IDNode2 { get; set; }
    }
}
