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

namespace NsTools
{

    class Program
    {
        public static void Main()
        {
            //  Paths paths = new Paths();

            //Console.WriteLine(paths.UserProfile(@"~"));

            //  var pp = @"~\Downloads".UserProfile();
            // Console.WriteLine(pp);
            //Office2013 office = new Office2013();
            //await office.DownloadOff2013();
            // office.InstallOffice2013();
            //RegistryReg reg = new RegistryReg("LocalMachine", "SOFTWARE\\Test", "Capitão", "5346864", RegistryValueKind.DWord);
            //reg.Create();

            //Create a new property of any type or update existing value of a property, but don't change name of the property existing.

            //System.Console.WriteLine(RegistryRegStatic.CreateOrModifyProperty("LocalMachine", "SOFTWARE", "Capitão", "1111111", RegistryValueKind.DWord).ToString());
            System.Console.WriteLine(RegistryRegStatic.DeleteProperty("LocalMachine", "SOFTWARE", "Capitão").ToString());



        }


    }







}
