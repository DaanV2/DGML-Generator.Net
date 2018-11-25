using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface IDGMLBuilder
    {
        /// <summary>TODO</summary>
        INode GetNode(string ID);

        /// <summary>TODO</summary>
        INode GetLink(string ID);
    }
}
