/*ISC License

Copyright (c) 2018, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConfigHandling;
using DGMLGenerator.Plugin.Definition;

//TODO prune namespace: DGMLGenerator
namespace DGMLGenerator
{
    public static partial class CodeProcessorsCollector
    {
        /// <summary>TODO</summary>
        /// <param name="Filepath"></param>
        /// <param name="builder"></param>
        public static void ProcessFile(string Filepath, IDGMLBuilder builder)
        {
            FileInfo FI = new FileInfo(Filepath);

            if (CodeProcessorsCollector.CodeProcessors.ContainsKey(FI.Extension))
            {
                CodeProcessorsCollector.CodeProcessors[FI.Extension].ProcessFile(Filepath, builder);
            }
        }

        /// <summary>TODO</summary>
        public static void LoadPlugins()
        {
            PluginSettings pluginSettings = ConfigMapper.Get<PluginSettings>();

            Plugins.Clear();

            string[] Files = Directory.GetFiles(pluginSettings.PluginFolder, pluginSettings.SearchPattern, SearchOption.AllDirectories);

            for (int I = 0; I < Files.Length; I++)
            {
#if !DEBUG
                try {
#endif
                Assembly assembly = Assembly.LoadFrom(Files[I]);
                CodeProcessorsCollector.Plugins.Add(assembly);
                MessageHandler.Writeline($"Loaded Plugin: {assembly.FullName}");
                MessageHandler.WriteProgress(I, Files.Length);
#if !DEBUG
                } catch (Exception ex) { MessageHandler.Writeline(ex.Message); }
#endif
            }

            LoadTypes();
        }

        /// <summary>TODO</summary>
        public static void LoadTypes()
        {
#if !DEBUG
                try {
#endif
            for (int I = 0; I < Plugins.Count; I++)
            {
                Assembly assembly = Plugins[I];
                Type[] DefinedObjects = assembly.GetTypes();

                for (int J = 0; J < DefinedObjects.Length; J++)
                {
                    Type[] Interfaces = DefinedObjects[J].GetInterfaces();

                    for (int K = 0; K < Interfaces.Length; K++)
                    {
                        if (Interfaces[K] == typeof(IPlugin))
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(DefinedObjects[J]);
                            LoadTypes(plugin.GetIPluginContext());
                        }
                    }
                }
            }
#if !DEBUG
                } catch (Exception ex) { MessageHandler.Writeline(ex.Message); }
#endif
        }

        /// <summary>TODO</summary>
        /// <param name="contexts"></param>
        public static void LoadTypes(List<IPluginContext> contexts)
        {
            string Key = string.Empty;
            for (int I = 0; I < contexts.Count; I++)
            {
                IPluginContext context = contexts[I];
                for (int J = 0; J < context.FileExtensions.Count; J++)
                {
                    Key = context.FileExtensions[J];
                    if (CodeProcessors.ContainsKey(Key))
                        CodeProcessors[Key] = context.CodeProcessor;

                    else
                        CodeProcessors.Add(Key, context.CodeProcessor);
                }
            }
        }
    }
}
