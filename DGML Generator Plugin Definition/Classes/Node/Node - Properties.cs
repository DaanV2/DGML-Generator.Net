﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    public partial class Node
    {
        ///TODO add description <summary></summary>
        public string ID { get; set; }

        ///TODO add description <summary></summary>
        public string Label { get; set; }

        ///TODO add description <summary></summary>
        public NodeType NodeType { get; set; }
    }
}
