using System;
using System.Text.Json;

namespace XQ.Net.SDK.Attributes
{
    /// <summary>
    /// 用来表示程序集为一个插件程序集
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class XQPluginAttribute : Attribute
    {
        public string Name;
        public string Author;
        public string Version;
        public string Desc;
        public int sdkv = 3;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">插件名</param>
        /// <param name="author">插件作者</param>
        /// <param name="version">插件版本</param>
        /// <param name="desc">插件描述</param>
        public XQPluginAttribute(string name, string author, string version, string desc)
        {
            Name = name;
            Author = author;
            Version = version;
            Desc = desc;
        }

    }
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {

    }

    public class PluginInfo
    {
        public string name { get; set; }
        public string pver { get; set; }
        public int sver { get; set; }
        public string author { get; set; }
        public string desc { get; set; }
    }
}