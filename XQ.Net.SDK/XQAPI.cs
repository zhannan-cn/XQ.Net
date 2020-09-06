using System;
using System.Linq;
using System.Text;

namespace XQ.Net.SDK
{
    public class XQAPI
    {
        public static byte[] AuthId;

        public void SetAuthID(int id, int addr)
        {
            AuthId = BitConverter.GetBytes(id).Concat(BitConverter.GetBytes(addr)).ToArray();
        }

        public void SendGroupMessage(string robot, string group, string qq, string msg)
        {
            XQDLL.S2_Api_SendMsgEX(AuthId, robot, 2, group, qq, msg, 0, false);
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

        public static string GetFriendList(string QQ)
        {
            return XQDLL.GetFriendList(AuthId, QQ);
        }

        public static string GetGroupList(string QQ)
        {
            return XQDLL.GetGroupList(AuthId, QQ);
        }

        public static string GetOnLineList()
        {
            return XQDLL.GetOnLineList(AuthId);
        }

        public static bool Getbotisonline(string QQ)
        {
            return XQDLL.Getbotisonline(AuthId, QQ);
        }

        public static string GetGroupMemberList(string QQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList(AuthId, QQ, GrouoQQ);
        }

        public static string GetGroupCard(string RobotQQ, string GrouoQQ, string QQ)
        {
            return XQDLL.GetGroupCard(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public static string GetGroupAdmin(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupAdmin(AuthId, RobotQQ, GrouoQQ);
        }

        public static string GetNotice(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetNotice(AuthId, RobotQQ, GrouoQQ);
        }

        public static bool IsShutUp(string RobotQQ, string GrouoQQ, string QQ)
        {
            return XQDLL.IsShutUp(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public static bool IfFriend(string RobotQQ, string QQ)
        {
            return XQDLL.IfFriend(AuthId, RobotQQ, QQ);
        }

        public static string GetGroupPsKey(string RobotQQ)
        {
            return XQDLL.GetGroupPsKey(AuthId, RobotQQ);
        }

        public static string GetZonePsKey(string RobotQQ)
        {
            return XQDLL.GetZonePsKey(AuthId, RobotQQ);
        }

        public static string GetCookies(string RobotQQ)
        {
            return XQDLL.GetCookies(AuthId, RobotQQ);
        }

        public static int GetObjVote(string RobotQQ, string QQ)
        {
            return XQDLL.GetObjVote(AuthId, RobotQQ, QQ);
        }

        public static bool IsEnable()
        {
            return XQDLL.IsEnable(AuthId);
        }

        public static string GetQQList()
        {
            return XQDLL.GetQQList(AuthId);
        }

        public static string GetNick(string RobotQQ, string QQ)
        {
            return XQDLL.GetNick(AuthId, RobotQQ, QQ);
        }

        public static string GetFriendsRemark(string RobotQQ, string QQ)
        {
            return XQDLL.GetFriendsRemark(AuthId, RobotQQ, QQ);
        }

        public static string GetClientkey(string RobotQQ)
        {
            return XQDLL.GetClientkey(AuthId, RobotQQ);
        }

        public static string GetLongClientkey(string RobotQQ)
        {
            return XQDLL.GetLongClientkey(AuthId, RobotQQ);
        }

        public static string GetClassRoomPsKey(string RobotQQ)
        {
            return XQDLL.GetClassRoomPsKey(AuthId, RobotQQ);
        }

        public static string GetRepPsKey(string RobotQQ)
        {
            return XQDLL.GetRepPsKey(AuthId, RobotQQ);
        }

        public static string GetTenPayPsKey(string RobotQQ)
        {
            return XQDLL.GetTenPayPsKey(AuthId, RobotQQ);
        }

        public static string GetBkn(string RobotQQ)
        {
            return XQDLL.GetBkn(AuthId, RobotQQ);
        }

        public static string GetGroupList_B(string RobotQQ)
        {
            return XQDLL.GetGroupList_B(AuthId, RobotQQ);
        }

        public static string GetFriendList_B(string RobotQQ)
        {
            return XQDLL.GetFriendList_B(AuthId, RobotQQ);
        }

        public static string GetQrcode(string key)
        {
            return XQDLL.GetQrcode(AuthId, key);
        }

        public static int CheckQrcode(string key)
        {
            return XQDLL.CheckQrcode(AuthId, key);
        }

        public static string GetGroupName(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupName(AuthId, RobotQQ, GrouoQQ);
        }

        public static string GetGroupMemberNum(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberNum(AuthId, RobotQQ, GrouoQQ);
        }

        public static int GetGroupLv(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupLv(AuthId, RobotQQ, GrouoQQ);
        }

        public static string GetGroupMemberList_B(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList_B(AuthId, RobotQQ, GrouoQQ);
        }

        public static string GetGroupMemberList_C(string RobotQQ, string GrouoQQ)
        {
            return XQDLL.GetGroupMemberList_C(AuthId, RobotQQ, GrouoQQ);
        }

        public static bool IsOnline(string RobotQQ, string QQ)
        {
            return XQDLL.IsOnline(AuthId, RobotQQ, QQ);
        }

        public static string GetRInf(string RobotQQ)
        {
            return XQDLL.GetRInf(AuthId, RobotQQ);
        }

        public static bool GetAnon(string RobotQQ, string GroupQQ)
        {
            return XQDLL.GetAnon(AuthId, RobotQQ, GroupQQ);
        }

        public static string GetPicLink(string RobotQQ, int ImageType, string GroupQQ, string ImageGUID)
        {
            return XQDLL.GetPicLink(AuthId, RobotQQ, ImageType, GroupQQ, ImageGUID);
        }

        public static int GetAge(string RobotQQ, string QQ)
        {
            return XQDLL.GetAge(AuthId, RobotQQ, QQ);
        }

        public static int GetGender(string RobotQQ, string QQ)
        {
            return XQDLL.GetGender(AuthId, RobotQQ, QQ);
        }

        public static void SendMsg(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID)
        {
            XQDLL.SendMsg(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID);
        }

        public static string UpLoadPic(string RobotQQ, int MessageType, string GrouoQQOrQQ, byte[] Message)
        {
            return XQDLL.UpLoadPic(AuthId, RobotQQ, MessageType, GrouoQQOrQQ, Message);
        }

        public static void ShutUP(string RobotQQ, string GrouoQQ, string QQ, int Time)
        {
            XQDLL.ShutUP(AuthId, RobotQQ, GrouoQQ, QQ, Time);
        }

        public static bool SetGroupCard(string RobotQQ, string GrouoQQ, string QQ, string Card)
        {
            return XQDLL.SetGroupCard(AuthId, RobotQQ, GrouoQQ, QQ, Card);
        }

        public static void KickGroupMBR(string RobotQQ, string GrouoQQ, string QQ, bool Allow)
        {
            XQDLL.KickGroupMBR(AuthId, RobotQQ, GrouoQQ, QQ, Allow);
        }

        public static void SetRInf(string RobotQQ, string OnLineType, string Message)
        {
            XQDLL.SetRInf(AuthId, RobotQQ, OnLineType, Message);
        }

        public static bool PBGroupNotic(string RobotQQ, string GrouoQQ, string MessageTitle, string Message)
        {
            return XQDLL.PBGroupNotic(AuthId, RobotQQ, GrouoQQ, MessageTitle, Message);
        }

        public static string WithdrawMsg(string RobotQQ, string GrouoQQ, string MessageNumber, string MessageID)
        {
            return XQDLL.WithdrawMsg(AuthId, RobotQQ, GrouoQQ, MessageNumber, MessageID);
        }

        public static void OutPutLog(string Message)
        {
            XQDLL.OutPutLog(AuthId, Message);
        }

        public static string OcrPic(string RobotQQ, byte[] ImageMessage)
        {
            return XQDLL.OcrPic(AuthId, RobotQQ, ImageMessage);
        }

        public static void JoinGroup(string RobotQQ, string GrouoQQ, string Message)
        {
            XQDLL.JoinGroup(AuthId, RobotQQ, GrouoQQ, Message);
        }

        public static string UpVote(string RobotQQ, string QQ)
        {
            return XQDLL.UpVote(AuthId, RobotQQ, QQ);
        }

        public static string UpVote_temp(string RobotQQ, string QQ)
        {
            return XQDLL.UpVote_temp(AuthId, RobotQQ, QQ);
        }

        public static void HandleFriendEvent(string RobotQQ, string QQ, int MessageType, string Message)
        {
            XQDLL.HandleFriendEvent(AuthId, RobotQQ, QQ, MessageType, Message);
        }

        public static void HandleGroupEvent(string RobotQQ, int RequestType, string QQ, string GrouoQQ, string Seq, int MessageType, string Message)
        {
            XQDLL.HandleGroupEvent(AuthId, RobotQQ, RequestType, QQ, GrouoQQ, Seq, MessageType, Message);
        }

        public static string AddQQ(string Account, string Password, bool Automatic)
        {
            return XQDLL.AddQQ(AuthId, Account, Password, Automatic);
        }

        public static void LoginQQ(string QQ)
        {
            XQDLL.LoginQQ(AuthId, QQ);
        }

        public static void OffLineQQ(string QQ)
        {
            XQDLL.OffLineQQ(AuthId, QQ);
        }

        public static string DelQQ(string QQ)
        {
            return XQDLL.DelQQ(AuthId, QQ);
        }

        public static bool DelFriend(string RobotQQ, string QQ)
        {
            return XQDLL.DelFriend(AuthId, RobotQQ, QQ);
        }

        public static void SetFriendsRemark(string RobotQQ, string QQ, string Message)
        {
            XQDLL.SetFriendsRemark(AuthId, RobotQQ, QQ, Message);
        }

        public static void InviteGroup(string RobotQQ, string GrouoQQ, string QQ)
        {
            XQDLL.InviteGroup(AuthId, RobotQQ, GrouoQQ, QQ);
        }

        public static bool InviteGroupMember(string RobotQQ, string GrouoQQ, string GrouoQQY, string QQ)
        {
            return XQDLL.InviteGroupMember(AuthId, RobotQQ, GrouoQQ, GrouoQQY, QQ);
        }

        public static string CreateDisGroup(string RobotQQ)
        {
            return XQDLL.CreateDisGroup(AuthId, RobotQQ);
        }

        public static string CreateGroup(string RobotQQ)
        {
            return XQDLL.CreateGroup(AuthId, RobotQQ);
        }

        public static void QuitGroup(string RobotQQ, string GrouoQQ)
        {
            XQDLL.QuitGroup(AuthId, RobotQQ, GrouoQQ);
        }

        public static void SetShieldedGroup(string RobotQQ, string GrouoQQ, bool MessageType)
        {
            XQDLL.SetShieldedGroup(AuthId, RobotQQ, GrouoQQ, MessageType);
        }

        public static void DelFriend_A(string RobotQQ, string QQ, int MessageType)
        {
            XQDLL.DelFriend_A(AuthId, RobotQQ, QQ, MessageType);
        }

        public static void Setcation(string RobotQQ, int MessageType)
        {
            XQDLL.Setcation(AuthId, RobotQQ, MessageType);
        }

        public static void Setcation_problem_A(string RobotQQ, string Problem, string Answer)
        {
            XQDLL.Setcation_problem_A(AuthId, RobotQQ, Problem, Answer);
        }

        public static void Setcation_problem_B(string RobotQQ, string Problem1, string Problem2, string Problem3)
        {
            XQDLL.Setcation_problem_B(AuthId, RobotQQ, Problem1, Problem2, Problem3);
        }

        public static bool AddFriend(string RobotQQ, string QQ, string Message, int xxlay)
        {
            return XQDLL.AddFriend(AuthId, RobotQQ, QQ, Message, xxlay);
        }

        public static void SendJSON(string RobotQQ, int SendType, int MessageType, string GrouoQQ, string QQ, string JsonMessage)
        {
            XQDLL.SendJSON(AuthId, RobotQQ, SendType, MessageType, GrouoQQ, QQ, JsonMessage);
        }

        public static void SendXML(string RobotQQ, int SendType, int MessageType, string GrouoQQ, string QQ, string XMLMessage)
        {
            XQDLL.SendXML(AuthId, RobotQQ, SendType, MessageType, GrouoQQ, QQ, XMLMessage);
        }

        public static string UpLoadVoice(string RobotQQ, int SendType, string GrouoQQ, byte[] Message)
        {
            return XQDLL.UpLoadVoice(AuthId, RobotQQ, SendType, GrouoQQ, Message);
        }

        public static string SendMsgEX(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID, bool Anonymous)
        {
            return XQDLL.SendMsgEX(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID, Anonymous);
        }

        public static string GetVoiLink(string RobotQQ, string Message)
        {
            return XQDLL.GetVoiLink(AuthId, RobotQQ, Message);
        }

        public static bool SetAnon(string RobotQQ, string GroupQQ, bool kg)
        {
            return XQDLL.SetAnon(AuthId, RobotQQ, GroupQQ, kg);
        }

        public static bool SetHeadPic(string RobotQQ, byte[] Message)
        {
            return XQDLL.SetHeadPic(AuthId, RobotQQ, Message);
        }

        public static string VoiToText(string RobotQQ, string ckdx, int cklx, string yyGUID)
        {
            return XQDLL.VoiToText(AuthId, RobotQQ, ckdx, cklx, yyGUID);
        }

        public static bool SignIn(string RobotQQ, string GroupQQ, string Address, string Message)
        {
            return XQDLL.SignIn(AuthId, RobotQQ, GroupQQ, Address, Message);
        }

        public static bool ShakeWindow(string RobotQQ, string QQ)
        {
            return XQDLL.ShakeWindow(AuthId, RobotQQ, QQ);
        }

        public static string SendMsgEX_V2(string RobotQQ, int MessageType, string GrouoQQ, string QQ, string Message, int BubbleID, bool Anonymous, string JSONMessage)
        {
            return XQDLL.SendMsgEX_V2(AuthId, RobotQQ, MessageType, GrouoQQ, QQ, Message, BubbleID, Anonymous, JSONMessage);
        }

        public static string WithdrawMsgEX(string RobotQQ, int WithdrawType, string GrouoQQ, string QQ, string MessageNumber, string MessageID, string MessageTime)
        {
            return XQDLL.WithdrawMsgEX(AuthId, RobotQQ, WithdrawType, GrouoQQ, QQ, MessageNumber, MessageID, MessageTime);
        }

        public static void DbgName(string Message)
        {
            XQDLL.DbgName(AuthId, Message);
        }

        public static void Mark(string Message)
        {
            XQDLL.Mark(AuthId, Message);
        }
    }
}