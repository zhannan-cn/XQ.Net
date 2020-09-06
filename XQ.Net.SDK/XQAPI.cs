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
        
        public string GetFriendList(string QQ)
        {
            return XQDLL.GetFriendList(AuthId, QQ);
        }

        public string GetGroupList(string QQ)
        {
            return XQDLL.GetGroupList(AuthId, QQ);
        }

        public string GetOnLineList()
        {
            return XQDLL.GetOnLineList(AuthId);
        }

        public bool Getbotisonline(string QQ)
        {
            return XQDLL.Getbotisonline(AuthId, QQ);
        }

        public string GetGroupMemberList(string QQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList(AuthId, QQ, GrouoQQ);
        }

        public string GetGroupCard(string RobotQQ, string GrouoQQ, string QQ)
        {
            return XQDLL.GetGroupCard(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public string GetGroupAdmin(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupAdmin(AuthId, RobotQQ, GrouoQQ);
        }

        public string GetNotice(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetNotice(AuthId, RobotQQ, GrouoQQ);
        }

        public bool IsShutUp(string RobotQQ, string GrouoQQ, string QQ)
        {
            return XQDLL.IsShutUp(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public bool IfFriend(string RobotQQ, string QQ)
        {
            return XQDLL.IfFriend(AuthId, RobotQQ, QQ);
        }

        public string GetGroupPsKey(string RobotQQ)
        {
            return XQDLL.GetGroupPsKey(AuthId, RobotQQ);
        }

        public string GetZonePsKey(string RobotQQ)
        {
            return XQDLL.GetZonePsKey(AuthId, RobotQQ);
        }

        public string GetCookies(string RobotQQ)
        {
            return XQDLL.GetCookies(AuthId, RobotQQ);
        }

        public int GetObjVote(string RobotQQ, string QQ)
        {
            return XQDLL.GetObjVote(AuthId, RobotQQ, QQ);
        }

        public bool IsEnable()
        {
            return XQDLL.IsEnable(AuthId);
        }

        public string GetQQList()
        {
            return XQDLL.GetQQList(AuthId);
        }

        public string GetNick(string RobotQQ, string QQ)
        {
            return XQDLL.GetNick(AuthId, RobotQQ, QQ);
        }

        public string GetFriendsRemark(string RobotQQ, string QQ)
        {
            return XQDLL.GetFriendsRemark(AuthId, RobotQQ, QQ);
        }

        public string GetClientkey(string RobotQQ)
        {
            return XQDLL.GetClientkey(AuthId, RobotQQ);
        }

        public string GetLongClientkey(string RobotQQ)
        {
            return XQDLL.GetLongClientkey(AuthId, RobotQQ);
        }

        public string GetClassRoomPsKey(string RobotQQ)
        {
            return XQDLL.GetClassRoomPsKey(AuthId, RobotQQ);
        }

        public string GetRepPsKey(string RobotQQ)
        {
            return XQDLL.GetRepPsKey(AuthId, RobotQQ);
        }

        public string GetTenPayPsKey(string RobotQQ)
        {
            return XQDLL.GetTenPayPsKey(AuthId, RobotQQ);
        }

        public string GetBkn(string RobotQQ)
        {
            return XQDLL.GetBkn(AuthId, RobotQQ);
        }

        public string GetGroupList_B(string RobotQQ)
        {
            return XQDLL.GetGroupList_B(AuthId, RobotQQ);
        }

        public string GetFriendList_B(string RobotQQ)
        {
            return XQDLL.GetFriendList_B(AuthId, RobotQQ);
        }

        public string GetQrcode(string key)
        {
            return XQDLL.GetQrcode(AuthId, key);
        }

        public int CheckQrcode(string key)
        {
            return XQDLL.CheckQrcode(AuthId, key);
        }

        public string GetGroupName(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupName(AuthId, RobotQQ, GrouoQQ);
        }

        public string GetGroupMemberNum(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberNum(AuthId, RobotQQ, GrouoQQ);
        }

        public int GetGroupLv(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupLv(AuthId, RobotQQ, GrouoQQ);
        }

        public string GetGroupMemberList_B(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList_B(AuthId, RobotQQ, GrouoQQ);
        }

        public string GetGroupMemberList_C(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList_C(AuthId, RobotQQ, GrouoQQ);
        }

        public bool IsOnline(string RobotQQ, string QQ)
        {
            return XQDLL.IsOnline(AuthId, RobotQQ, QQ);
        }

        public string GetRInf(string RobotQQ)
        {
            return XQDLL.GetRInf(AuthId, RobotQQ);
        }

        public bool GetAnon(string RobotQQ, string GroupQQ)
        {
            return XQDLL.GetAnon(AuthId, RobotQQ, GroupQQ);
        }

        public string GetPicLink(string RobotQQ, int ImageType, string GroupQQ, string ImageGUID)
        {
            return XQDLL.GetPicLink(AuthId, RobotQQ, ImageType, GroupQQ, ImageGUID);
        }

        public int GetAge(string RobotQQ, string QQ)
        {
            return XQDLL.GetAge(AuthId, RobotQQ, QQ);
        }

        public int GetGender(string RobotQQ, string QQ)
        {
            return XQDLL.GetGender(AuthId, RobotQQ, QQ);
        }

        public void SendMsg(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID)
        {
            XQDLL.SendMsg(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID);
        }

        public string UpLoadPic(string RobotQQ, int MessageType, string GrouoQQOrQQ, byte[] Message)
        {
            return XQDLL.UpLoadPic(AuthId, RobotQQ, MessageType, GrouoQQOrQQ, Message);
        }

        public void ShutUP(string RobotQQ, string GrouoQQ, string QQ, int Time)
        {
            XQDLL.ShutUP(AuthId, RobotQQ, GrouoQQ, QQ, Time);
        }

        public bool SetGroupCard(string RobotQQ, string GrouoQQ, string QQ, string Card)
        {
            return XQDLL.SetGroupCard(AuthId, RobotQQ, GrouoQQ, QQ, Card);
        }

        public void KickGroupMBR(string RobotQQ, string GrouoQQ, string QQ, bool Allow)
        {
            XQDLL.KickGroupMBR(AuthId, RobotQQ, GrouoQQ, QQ, Allow);
        }

        public void SetRInf(string RobotQQ, string OnLineType, string Message)
        {
            XQDLL.SetRInf(AuthId, RobotQQ, OnLineType, Message);
        }

        public bool PBGroupNotic(string RobotQQ, string GrouoQQ, string MessageTitle, string Message)
        {
            return XQDLL.PBGroupNotic(AuthId, RobotQQ, GrouoQQ, MessageTitle, Message);
        }

        public string WithdrawMsg(string RobotQQ, string GrouoQQ, string MessageNumber, string MessageID)
        {
            return XQDLL.WithdrawMsg(AuthId, RobotQQ, GrouoQQ, MessageNumber, MessageID);
        }

        public void OutPutLog(string Message)
        {
            XQDLL.OutPutLog(AuthId, Message);
        }

        public string OcrPic(string RobotQQ, byte[] ImageMessage)
        {
            return XQDLL.OcrPic(AuthId, RobotQQ, ImageMessage);
        }

        public void JoinGroup(string RobotQQ, string GrouoQQ, string Message)
        {
            XQDLL.JoinGroup(AuthId, RobotQQ, GrouoQQ, Message);
        }

        public string UpVote(string RobotQQ, string QQ)
        {
            return XQDLL.UpVote(AuthId, RobotQQ, QQ);
        }

        public string UpVote_temp(string RobotQQ, string QQ)
        {
            return XQDLL.UpVote_temp(AuthId, RobotQQ, QQ);
        }

        public void HandleFriendEvent(string RobotQQ, string QQ, int MessageType, string Message)
        {
            XQDLL.HandleFriendEvent(AuthId, RobotQQ, QQ, MessageType, Message);
        }

        public void HandleGroupEvent(string RobotQQ, int RequestType, string QQ, string GrouoQQ, string Seq, int MessageType, string Message)
        {
            XQDLL.HandleGroupEvent(AuthId, RobotQQ, RequestType, QQ, GrouoQQ, Seq, MessageType, Message);
        }

        public string AddQQ(string Account, string Password, bool Automatic)
        {
            return XQDLL.AddQQ(AuthId, Account, Password, Automatic);
        }

        public void LoginQQ(string QQ)
        {
            XQDLL.LoginQQ(AuthId, QQ);
        }

        public void OffLineQQ(string QQ)
        {
            XQDLL.OffLineQQ(AuthId, QQ);
        }

        public string DelQQ(string QQ)
        {
            return XQDLL.DelQQ(AuthId, QQ);
        }

        public bool DelFriend(string RobotQQ, string QQ)
        {
            return XQDLL.DelFriend(AuthId, RobotQQ, QQ);
        }

        public void SetFriendsRemark(string RobotQQ, string QQ, string Message)
        {
            XQDLL.SetFriendsRemark(AuthId, RobotQQ, QQ, Message);
        }

        public void InviteGroup(string RobotQQ, string GrouoQQ, string QQ)
        {
            XQDLL.InviteGroup(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public bool InviteGroupMember(string RobotQQ, string GrouoQQ, string GrouoQQY, string QQ)
        {
            return XQDLL.InviteGroupMember(AuthId, RobotQQ, GrouoQQ, GrouoQQY, QQ);
        }

        public string CreateDisGroup(string RobotQQ)
        {
            return XQDLL.CreateDisGroup(AuthId, RobotQQ);
        }

        public string CreateGroup(string RobotQQ)
        {
            return XQDLL.CreateGroup(AuthId, RobotQQ);
        }

        public void QuitGroup(string RobotQQ, string GrouoQQ)
        {
            XQDLL.QuitGroup(AuthId, RobotQQ, GrouoQQ);
        }

        public void SetShieldedGroup(string RobotQQ, string GrouoQQ, bool MessageType)
        {
            XQDLL.SetShieldedGroup(AuthId, RobotQQ, GrouoQQ, MessageType);
        }

        public void DelFriend_A(string RobotQQ, string QQ, int MessageType)
        {
            XQDLL.DelFriend_A(AuthId, RobotQQ, QQ, MessageType);
        }

        public void Setcation(string RobotQQ, int MessageType)
        {
            XQDLL.Setcation(AuthId, RobotQQ, MessageType);
        }

        public void Setcation_problem_A(string RobotQQ, string Problem, string Answer)
        {
            XQDLL.Setcation_problem_A(AuthId, RobotQQ, Problem, Answer);
        }

        public void Setcation_problem_B(string RobotQQ, string Problem1, string Problem2, string Problem3)
        {
            XQDLL.Setcation_problem_B(AuthId, RobotQQ, Problem1, Problem2, Problem3);
        }

        public bool AddFriend(string RobotQQ, string QQ, string Message, int xxlay)
        {
            return XQDLL.AddFriend(AuthId, RobotQQ, QQ, Message, xxlay);
        }

        public void SendJSON(string RobotQQ, int SendType, int MessageType, string GrouoQQ, string QQ, string JsonMessage)
        {
            XQDLL.SendJSON(AuthId, RobotQQ, SendType, MessageType, GrouoQQ, QQ, JsonMessage);
        }

        public void SendXML(string RobotQQ, int SendType, int MessageType, string GrouoQQ, string QQ, string XMLMessage)
        {
            XQDLL.SendXML(AuthId, RobotQQ, SendType, MessageType, GrouoQQ, QQ, XMLMessage);
        }

        public string UpLoadVoice(string RobotQQ, int SendType, string GrouoQQ, byte[] Message)
        {
            return XQDLL.UpLoadVoice(AuthId, RobotQQ, SendType, GrouoQQ, Message);
        }

        public string SendMsgEX(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID, bool Anonymous)
        {
            return XQDLL.SendMsgEX(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID, Anonymous);
        }

        public string GetVoiLink(string RobotQQ, string Message)
        {
            return XQDLL.GetVoiLink(AuthId, RobotQQ, Message);
        }

        public bool SetAnon(string RobotQQ, string GroupQQ, bool kg)
        {
            return XQDLL.SetAnon(AuthId, RobotQQ, GroupQQ, kg);
        }

        public bool SetHeadPic(string RobotQQ, byte[] Message)
        {
            return XQDLL.SetHeadPic(AuthId, RobotQQ, Message);
        }

        public string VoiToText(string RobotQQ, string ckdx, int cklx, string yyGUID)
        {
            return XQDLL.VoiToText(AuthId, RobotQQ, ckdx, cklx, yyGUID);
        }

        public bool SignIn(string RobotQQ, string GroupQQ, string Address, string Message)
        {
            return XQDLL.SignIn(AuthId, RobotQQ, GroupQQ, Address, Message);
        }

        public bool ShakeWindow(string RobotQQ, string QQ)
        {
            return XQDLL.ShakeWindow(AuthId, RobotQQ, QQ);
        }

        public string SendMsgEX_V2(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID, bool Anonymous, string JSONMessage)
        {
            return XQDLL.SendMsgEX_V2(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID, Anonymous, JSONMessage);
        }

        public string WithdrawMsgEX(string RobotQQ, int WithdrawType, string GrouoQQ, string QQ, string MessageNumber, string MessageID, string MessageTime)
        {
            return XQDLL.WithdrawMsgEX(AuthId, RobotQQ, WithdrawType, GrouoQQ, QQ, MessageNumber, MessageID, MessageTime);
        }

        public void DbgName(string Message)
        {
            XQDLL.DbgName(AuthId, Message);
        }

        public void Mark(string Message)
        {
            XQDLL.Mark(AuthId, Message);
        }
        
        
    }
}
