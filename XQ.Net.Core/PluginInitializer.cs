using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace XQ.Net.Core
{
    internal class PluginInitializer
    {

        public static void Init(Assembly assembly)
        {
            foreach (var item in assembly.GetTypes())
            {

            }
        }
    }
}
