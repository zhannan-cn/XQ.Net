using System;
using System.Collections.Generic;
using System.Text;

namespace XQ.Net.SDK.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GroupMsgEventAttribute:Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class PrivateMsgEventAttribute : Attribute
    {
    }

    
}
