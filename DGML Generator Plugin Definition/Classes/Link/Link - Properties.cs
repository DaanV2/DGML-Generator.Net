using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO prune namespace: DGMLGenerator.Plugin.Definition
namespace DGMLGenerator.Plugin.Definition
{
    public partial class Link
    {
        /// <summary>TODO</summary>
        public string Label { get; set; }

        /// <summary>TODO</summary>
        public LinkType LinkType { get; set; }

        /// <summary>TODO</summary>
        public string ID { get; set; }

        /// <summary>TODO</summary>
        public string IDNode1 { get; set; }

        /// <summary>TODO</summary>
        public string IDNode2 { get; set; }
    }
}
