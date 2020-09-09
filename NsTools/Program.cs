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
            AnyDesk anyDesk = new AnyDesk();
            TeamViewer teamViewer = new TeamViewer();
            await teamViewer.TeamViewerFix();
            await anyDesk.AnyDeskFix();
        }






    }
}
