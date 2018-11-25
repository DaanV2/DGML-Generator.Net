using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigHandling;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    /// <summary>TODO add description for class: PluginSettings</summary>
	[Serializable]
    public partial class PluginSettings : Config
    {
        /// <summary>Creates a new instance of <see cref="PluginSettings"/></summary>
        public PluginSettings()
        {
            this.PluginFolder = AppDomain.CurrentDomain.BaseDirectory + "//Plugins//";
            this.SearchPattern = "*.dll";
            this.SearchOptions = SearchOption.AllDirectories;
        }
    }
}
