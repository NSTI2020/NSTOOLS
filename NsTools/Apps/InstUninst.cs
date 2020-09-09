using NsTools.Apps.Installers;
using NsTools.Has;
using NsTools.Online;
using NsTools.Procs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NsTools.Installer
{
    public class InstUninst
    {
        private Download Online { get; set; }
        private ProcessInvoke Invoke { get; set; }
        private Installed installedX64LM { get; set; }

       public InstUninst()
        {
            
        }

        public InstUninst(string path, string args)
        {
            Invoke = new ProcessInvoke(path, args);
        }
        public void App()
        {
            Invoke.InvokeProc();
        }

        public void Uninstall(string path, string args)
        {
            Invoke = new ProcessInvoke(path, args);
            Invoke.InvokeProc();
        }
        
        public async Task AppOnline(string urlToDown, string downFileTarget, string args)
        {
           Online = new Download(urlToDown, downFileTarget);
            await Online.GetThis();

        }
        public string GetStringUninstall(string name, string registryHive, string regKey, string nameInValue)
        {
            installedX64LM = new Installed(registryHive, regKey, nameInValue);
            return installedX64LM.SearchPropertName(name);
        }



    }
}
