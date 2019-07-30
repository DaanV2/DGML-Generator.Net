using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator
{
    public static partial class MessageHandler
    {
        ///TODO add description <summary></summary>
        public static event MessageEventHandler MessageOut;

        ///TODO add description <summary></summary>
        public static event ProgressEventHandler ProgressOut;
    }
}
