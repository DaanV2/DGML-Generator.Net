using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO prune namespace: DGMLGenerator.Plugin.Definition
namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO add description for class: Node</summary>
	[Serializable]
    public partial class Node
    {
        /// <summary>Creates a new instance of <see cref="Node"/></summary>
        public Node()
        {
            this.ID = string.Empty;
            this.Label = string.Empty;
            this.NodeType = NodeType.Class;
        }

        /// <summary>Creates a new instance of <see cref="Node"/></summary>
        public Node(string ID) : this()
        {
            this.ID = ID;
        }

        /// <summary>TODO</summary>
        /// <param name="ID"></param>
        /// <param name="Label"></param>
        /// <param name="NodeType"></param>
        public Node(string ID, string Label, NodeType NodeType)
        {
            this.ID = ID;
            this.Label = Label;
            this.NodeType = NodeType;
        }
    }
}
