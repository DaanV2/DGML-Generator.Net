using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    public static partial class MessageHandler
    {
        /// <summary>TODO</summary>
        public static event MessageEventHandler MessageOut;

        /// <summary>TODO</summary>
        public static event ProgressEventHandler ProgressOut;
    }
}
