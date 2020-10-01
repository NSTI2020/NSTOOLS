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

namespace NsTools
{
    
    class Program
    { 
        public static void Main()
        {


            var pp = @"~\Downloads".UserProfile();
            Console.WriteLine(pp);
            //Office2013 office = new Office2013();
            //await office.DownloadOff2013();
            // office.InstallOffice2013();




        }

       
    }







}
