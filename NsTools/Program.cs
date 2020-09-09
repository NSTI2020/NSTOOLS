using System.Threading.Tasks;
using NsTools.Apps.Installers;
using NsTools.Apps;
using NsTools.Procs;
using NsTools.Installer;
using System;

namespace NsTools
{
    class Program
    {
        static async Task Main(string[] args)
        {

             TeamViewer teamViewer = new TeamViewer();
             await teamViewer.TeamViewerFix();
            /*MsgsApps msg = new MsgsApps("Team Viewer. please, wait...", "Team Viewer. please, wait...", "Team Viewer. please, wait...");
            Console.WriteLine(msg.WriteMsg());*/


        }






    }
}
