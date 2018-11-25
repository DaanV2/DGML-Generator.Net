using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGMLGenerator.Plugin.Definition;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    public partial class DGMLBuilder : IDGMLBuilder
    {
        /// <summary>TODO</summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Link GetLink(string ID)
        {
            if (!this.Links.ContainsKey(ID))
                this.Links.AddIf(ID, new Link(ID));

            return this.Links[ID];
        }

        /// <summary>TODO</summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Node GetNode(string ID)
        {
            if (!this.Nodes.ContainsKey(ID))
                this.Nodes.AddIf(ID, new Node(ID));

            return this.Nodes[ID];
        }

        /// <summary>TODO</summary>
        /// <param name="L"></param>
        public void SetLink(Link L)
        {
            this.Links[L.ID] = L;
        }

        /// <summary>TODO</summary>
        /// <param name="N"></param>
        public void SetNode(Node N)
        {
            this.Nodes[N.ID] = N;
        }
    }
}
