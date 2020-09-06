using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using XQ.Net.SDK;
using XQ.Net.SDK.EventArgs;

namespace XQ.Net.Core.Export
{
    internal class _Main
    {
        public static XQAPI xqapi = new XQAPI();

        /// <summary>
        /// 容器
        /// </summary>
        public UnityContainer Container { get; set; } = new UnityContainer();

        #region 事件
        public static event EventHandler<XQAppGroupMsgEventArgs> Event_GroupMsgHandler;
        #endregion
    }
}
