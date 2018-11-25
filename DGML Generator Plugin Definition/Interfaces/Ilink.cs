using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface ILink
    {
        /// <summary>TODO</summary>
        string Label { get; set; }

        /// <summary>TODO</summary>
        LinkType LinkType { get; set; }
    }
}
