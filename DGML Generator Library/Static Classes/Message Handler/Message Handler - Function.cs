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
        /// <param name="Message"></param>
        public static void Writeline(string Message)
        {
            MessageHandler.MessageOut?.Invoke(Message);
        }

        /// <summary>TODO</summary>
        public static void WriteProgress(int Value, int Maximum)
        {
            MessageHandler.ProgressOut?.Invoke(Value, Maximum);
        }
    }
}
