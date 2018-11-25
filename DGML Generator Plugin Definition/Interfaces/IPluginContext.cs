using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface IPluginContext
    {
        /// <summary>TODO</summary>
        List<string> FileExtensions { get; set; }

        /// <summary>TODO</summary>
        ICodeProcessor CodeProcessor { get; set; }
    }
}
