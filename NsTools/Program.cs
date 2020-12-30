using System.Threading.Tasks;
using NsTools.Apps.Installers;
using NsTools.Apps;
using System;
using NsTools.Useful.Has;
using NsTools.NetWork;
using NsTools.Hardware.Basic;
using System.Net.NetworkInformation;
using System.Linq;
using NsTools.NetWork.GetConfigs;
using System.Management;
using System.Collections;
using NsTools.Repairs.Basic;
using System.IO;
using NsTools.Useful;
using NsTools.Useful.Generics;
using NsTools.Useful.Reg;
using Microsoft.Win32;
using NsTools.Os.Basic.Accounts;
using System.DirectoryServices.AccountManagement;
using System.Collections.Generic;

namespace NsTools
{
    class Program
    {
        public static void Main()
        {

            Group.getMembers("administradores");
        }
    }
}
