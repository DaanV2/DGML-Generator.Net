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
        /// <param name="Message"></param>
        public static void Writeline(string Message)
        {
            MessageHandler.MessageOut?.Invoke(Message);
        }

        ///TODO add description <summary></summary>
        public static void WriteProgress(int Value, int Maximum)
        {
            MessageHandler.ProgressOut?.Invoke(Value, Maximum);
        }
    }
}
