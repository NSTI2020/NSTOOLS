using System.Threading.Tasks;
using NsTools.Apps.Installers;
using NsTools.Apps;
using NsTools.Procs;
using NsTools.Installer;
using System;
using NsTools.Has;

namespace NsTools
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
             TeamViewer teamViewer = new TeamViewer();
             await teamViewer.TeamViewerFix();

       AnyDesk anyDesk = new AnyDesk();

        await anyDesk.AnyDeskFix();*/


            InstUninst Inst = new InstUninst();
            string save = Inst.GetStringUninstallMsi("AnyDesk MSI", "LocalMachine", @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName");

           save.Replace()
            
            Console.WriteLine(Inst.GetStringUninstallMsi("AnyDesk MSI", "LocalMachine", @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName"));



        }






    }
}
