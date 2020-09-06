﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XQ.Net.SDK.Models
{
    /// <summary>
    /// 相应QQ(机器人)的实体类
    /// </summary>
    public class XQRobot : BaseModel
    {
        public XQRobot(string qq,XQAPI api) : base(api)
        {
            this.RobotQQ = qq;
        }

        /// <summary>
        /// 相应QQ号
        /// </summary>
        public string RobotQQ { get; set; }

        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="groupid"></param>
        /// <param name="msg"></param>
        public void SendGroupMessage(string groupid,string msg)
        {
            new XQGroup(groupid,XQAPI).SendMessage(RobotQQ, msg);
        }
        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="groupid"></param>
        /// <param name="msg"></param>
        public void SendGroupMessage(XQGroup group, string msg)
        {
            group.SendMessage(RobotQQ, msg);
        }

        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="qq"></param>
        /// <param name="msg"></param>
        public void SendPrivateMessage(string qq, string msg)
        {
            new XQQQ(qq,XQAPI).SendMessage(RobotQQ, msg);
        }
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="qq"></param>
        /// <param name="msg"></param>
        public void SendPrivateMessage(XQQQ qq, string msg)
        {
           qq.SendMessage(RobotQQ, msg);

        }

        //public IEnumerable<XQGroup> GetGroupList()
        //{
        //    return XQDLL.Api_GetGroupList_B(RobotQQ).Split('\n').ToList().Select(s=>new XQGroup(s,XQAPI));
        //}

        public string GetGroupMemberList(string group)
        {
           //var json = XQDLL.Api_GetGroupMemberList_B(RobotQQ,group);
            return "";
        }
    }
}
