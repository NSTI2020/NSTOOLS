using System.Threading.Tasks;
using NsTools.Apps.Installers;
using NsTools.Apps;
using NsTools.Procs;
using NsTools.Installer;
using System;
using NsTools.Has;
using NsTools.NetWork;
using NsTools.Hardware.Basic;
using System.Net.NetworkInformation;
using System.Linq;
using NsTools.NetWork.Configs;
using System.Management;
using System.Collections;
using NsTools.Repairs.Basic;
using System.IO;
using NsTools.Useful;

namespace NsTools
{
    class Program
    {
        public async static Task Main(string[] args)
        {
           Office2013 office = new Office2013();
           await office.DownloadOff2013();
           office.InstallOffice2013();
        }
   








    }
}
