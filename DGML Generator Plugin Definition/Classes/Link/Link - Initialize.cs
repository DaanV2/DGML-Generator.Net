using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>//TODO add description for class: Link</summary>
	[Serializable]
    public partial class Link
    {
        /// <summary>Creates a new instance of <see cref="Link"/></summary>
        public Link()
        {
            this.ID = string.Empty;
            this.Label = string.Empty;
            this.LinkType = LinkType.Call;
            this.IDNode1 = string.Empty;
            this.IDNode2 = string.Empty;
        }

        ///TODO add description <summary></summary>
        /// <param name="ID"></param>
        public Link(string ID) : this()
        {
            this.ID = ID;
        }

        ///TODO add description <summary></summary>
        /// <param name="IDNode1"></param>
        /// <param name="IDNode2"></param>
        /// <param name="Label"></param>
        /// <param name="LinkType"></param>
        public Link(string IDNode1, string IDNode2, string Label = "", LinkType LinkType = LinkType.Call)
        {
            this.ID = IDNode1 + IDNode2;
            this.Label = Label;
            this.LinkType = LinkType;
            this.IDNode1 = IDNode1;
            this.IDNode2 = IDNode2;
        }

        ///TODO add description <summary></summary>
        /// <param name="Node1"></param>
        /// <param name=""></param>
        /// <param name="Label"></param>
        /// <param name="LinkType"></param>
        public Link(Node Node1, Node Node2, string Label = "", LinkType LinkType = LinkType.Call)
        {
            this.ID = Node1.ID + Node2.ID;
            this.Label = Label;
            this.LinkType = LinkType;
            this.IDNode1 = Node1.ID;
            this.IDNode2 = Node2.ID;
        }
    }
}
