using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XQ.Net.SDK.EventArgs;

namespace XQ.Net.SDK.Interfaces
{
    public interface IXQAddGroup
    {
        void AddGroup(object sender,XQAddGroupEventArgs e);
    }
}
