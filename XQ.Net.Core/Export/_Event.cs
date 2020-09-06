using System;
using System.Collections.Generic;
using System.Text;
using HuajiTech.UnmanagedExports;
using XQ.Net.SDK;

namespace XQ.Net.Core.Export
{
    public class _Event
    {
        [DllExport]
        public static int
            XQ_Event(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, int p) => Event(robotQQ, eventType, extraType, from, fromQQ, targetQQ, content, index, msgid, udpmsg, unix, p);

        public static int Event(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, int p)
        {
            //if (eventType == (int)XQEventType.Group)
            //{
            //    if (Event_GroupMsgHandler != null)//群聊消息
            //    {
            //        XQAppGroupMsgEventArgs args = new XQAppGroupMsgEventArgs(robotQQ, (int)eventType, (int)extraType, from, fromQQ, content, index, msgid, _Main.xqapi);
            //        Event_GroupMsgHandler(typeof(XQEvent), args);
            //        return (args.Handler ? 2 : 1);
            //        //阻塞返回2，继续返回1
            //    }
            //}

            return 1;
        }
    }
}