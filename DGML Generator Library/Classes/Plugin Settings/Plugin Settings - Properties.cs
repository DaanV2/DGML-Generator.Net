using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    public partial class PluginSettings
    {
        /// <summary>TODO</summary>
        public string PluginFolder { get; set; }

        /// <summary>TODO</summary>
        public SearchOption SearchOptions { get; set; }

        /// <summary>TODO</summary>
        public string SearchPattern { get; set; }
    }
}
