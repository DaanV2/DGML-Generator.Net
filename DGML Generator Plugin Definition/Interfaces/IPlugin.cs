using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface IPlugin
    {
        /// <summary>TODO</summary>
        /// <param name="Contenxt"></param>
        void SetInfo(IPluginContext Contenxt);
    }
}
