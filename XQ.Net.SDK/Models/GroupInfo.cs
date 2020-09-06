using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XQ.Net.SDK.Models
{
    public class GroupInfo
    {
        public GroupInfo(string robotQQ, string id)
        {
            Id = id;

            Name = XQAPI.GetGroupName(robotQQ, id);
        }

        public GroupInfo(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 群名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 创建者QQ号
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// 获取成员信息
        /// </summary>
        /// <param name="robotQQ"></param>
        /// <returns></returns>
        public string GetMemberInfo(string robotQQ)
        {
            return XQAPI.GetGroupMemberList(robotQQ, Id);
        }
    }
}