﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XQ.Net.SDK.EventArgs;

namespace XQ.Net.SDK.Interfaces
{
    /// <summary>
    /// 好友添加相关事件
    /// </summary>
    public interface IXQAddFriend
    {
        void AddFriend(object sender, XQAddFriendEventArgs e);
    }
}
