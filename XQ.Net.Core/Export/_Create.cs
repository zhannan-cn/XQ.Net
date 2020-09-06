using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;
using HuajiTech.UnmanagedExports;
using XQ.Net.SDK.Attributes;

namespace XQ.Net.Core.Export
{
    public class _Create
    {
        [DllExport]
        public static string XQ_Create(string frameworkversion) => CreateMain();


        public static string CreateMain()
        {
            //解析Assembly
            foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                var plugin = ass.GetCustomAttribute<XQPluginAttribute>();
                if (plugin != null)
                {
                    PluginInitializer.Init(ass);
                    return JsonSerializer.Serialize(new PluginInfo()
                    {
                        name = plugin.Name,
                        pver = plugin.Version,
                        sver = plugin.sdkv,
                        author = plugin.Author,
                        desc = plugin.Desc
                    });
                }
            }

            throw new Exception("未找到相关程序集");
            


        }
    }
}
