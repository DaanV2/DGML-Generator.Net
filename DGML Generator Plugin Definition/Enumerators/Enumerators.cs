using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public enum LinkType
    {
        /// <summary>TODO</summary>
        Child,
        /// <summary>TODO</summary>
        Call
    }

    /// <summary>TODO</summary>
    public enum NodeType
    {
        /// <summary>TODO</summary>
        Method,
        /// <summary>TODO</summary>
        Property,
        /// <summary>TODO</summary>
        Field,
        /// <summary>TODO</summary>
        Class,
        /// <summary>TODO</summary>
        Structure,
        /// <summary>TODO</summary>
        Object,
        /// <summary>TODO</summary>
        Namespace
    }
}
