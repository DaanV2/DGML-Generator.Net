using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGMLGenerator.Plugin.Definition
{
    /// <summary>TODO</summary>
    public interface ICodeProcessor
    {
        /// <summary>TODO</summary>
        /// <param name="Filepath"></param>
        /// <param name="builder"></param>
        void ProcessFile(string Filepath, IDGMLBuilder builder);
    }
}
