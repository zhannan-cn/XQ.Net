using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace XQ.Net.SDK
{
    internal class XQDLL
    {
        const string DLLName = "xqapi.dll";

        [DllImport(DLLName)]
        public static extern string S2_Api_SendMsgEX(byte[] autoid, string robot, int type, string targetgroup, string targetqq, string content, int bubble, bool anyn);

        internal static object Api_GetGroupList_B(string robotQQ)
        {
            throw new NotImplementedException();
        }
    }
}
