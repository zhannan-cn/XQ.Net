﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XQ.Net.SDK.EventArgs;

namespace XQ.Net.SDK.Interfaces
{
    public interface IXQPrivateMessage
    {
        /// <summary>
        /// 主入口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PrivateMessage(object sender, XQAppPrivateMsgEventArgs e);
    }
}
