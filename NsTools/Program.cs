﻿using System.Threading.Tasks;
using NsTools.Apps.Installers;
using NsTools.Apps;
using NsTools.Procs;
using NsTools.Installer;
using System;
using NsTools.Has;
using NsTools.NetWork;
using System.Net.NetworkInformation;
using System.Linq;
using NsTools.NetWork.Configs;
using System.Management;
using System.Collections;

namespace NsTools
{
    class Program
    {
        public static void Main(string[] args)
        {
            t();
        }
        public static void t()
        {
            BasicNetWorkInformation basic = new BasicNetWorkInformation();

            Console.WriteLine(basic.AssActiveAdapterName());


        }
        

    }
}
