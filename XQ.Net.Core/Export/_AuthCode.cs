using System;
using System.Collections.Generic;
using System.Text;
using HuajiTech.UnmanagedExports;
using XQ.Net.SDK;

namespace XQ.Net.Core.Export
{
    public class _AuthCode
    {
        [DllExport]
        public static void XQ_AutoId(short id, int IMAddr) => AuthCode(id, IMAddr);

        public static void AuthCode(short id, int IMAddr)
        {
            _Main.xqapi.SetAuthID(id, IMAddr);
        }
    }
}