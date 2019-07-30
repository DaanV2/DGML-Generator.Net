using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator
{
    ///TODO add description <summary></summary>
    /// <param name="Message"></param>
    public delegate void MessageEventHandler(string Message);

    ///TODO add description <summary></summary>
    /// <param name="Value"></param>
    /// <param name="Maximum"></param>
    public delegate void ProgressEventHandler(int Value, int Maximum);
}
