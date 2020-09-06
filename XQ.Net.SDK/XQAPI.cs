using System;
using System.Linq;
using System.Text;

namespace XQ.Net.SDK
{
    public class XQAPI
    {
        public byte[] AuthId;


        public void SetAuthID (int id,int addr)
        {
            AuthId = BitConverter.GetBytes(id) .Concat(BitConverter.GetBytes(addr)).ToArray();
        }

        public void SendGroupMessage(string robot,string group,string qq,string msg)
        {
            XQDLL.S2_Api_SendMsgEX(AuthId,robot,2,group,qq,msg,0,false);
        }

        internal void KickGroupMember(string robotQQ, string id, string targetQQ, bool blacklist)
        {
            throw new NotImplementedException();
        }

        internal void SendGroupMessage(string robotQQ, string id, string msg)
        {
            throw new NotImplementedException();
        }

        internal void SendPrivateMessage(string robotQQ, string id, string msg)
        {
            throw new NotImplementedException();
        }

        internal void ShutUpMember(string robotQQ, string id, string targetQQ, int seconds)
        {
            throw new NotImplementedException();
        }
    }
}
