using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGMLGenerator.Plugin.Definition;

namespace DGMLGenerator
{
    public partial class DGMLBuilder : IDGMLBuilder
    {
        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        public void Add(params Node[] Nodes)
        {
            foreach (Node N in Nodes)
                this.Nodes[N.ID] = N;
        }

        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        public void Add(List<Node> Nodes)
        {
            throw new NotImplementedException();
        }

        ///TODO add description <summary></summary>
        /// <param name="Links"></param>
        public void Add(params Link[] Links)
        {
            throw new NotImplementedException();
        }

        ///TODO add description <summary></summary>
        /// <param name="Nodes"></param>
        public void Add(List<Link> Nodes)
        {
            throw new NotImplementedException();
        }

        ///TODO add description <summary></summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Link GetLink(string ID)
        {
            if (!this.Links.ContainsKey(ID))
                this.Links.AddIf(ID, new Link(ID));

            return this.Links[ID];
        }

        ///TODO add description <summary></summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Node GetNode(string ID)
        {
            if (!this.Nodes.ContainsKey(ID))
                this.Nodes.AddIf(ID, new Node(ID));

            return this.Nodes[ID];
        }

        ///TODO add description <summary></summary>
        /// <param name="L"></param>
        public void SetLink(Link L)
        {
            this.Links[L.ID] = L;
        }

        ///TODO add description <summary></summary>
        /// <param name="N"></param>
        public void SetNode(Node N)
        {
            this.Nodes[N.ID] = N;
        }
    }
}
