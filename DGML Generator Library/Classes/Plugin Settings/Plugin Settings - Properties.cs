﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator
{
    public partial class PluginSettings
    {
        ///TODO add description <summary></summary>
        public string PluginFolder { get; set; }

        ///TODO add description <summary></summary>
        public SearchOption SearchOptions { get; set; }

        ///TODO add description <summary></summary>
        public string SearchPattern { get; set; }
    }
}
