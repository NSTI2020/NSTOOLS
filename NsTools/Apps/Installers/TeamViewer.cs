using System;
using System.IO;
using System.Threading.Tasks;
using NsTools.Has;
using NsTools.Installer;
using NsTools.Procs;

namespace NsTools.Apps.Installers
{
    class TeamViewer
    {
        private Exists _exists { get; set; }
        private InstUninst _installUninstall { get; set; }
        private string _userProfile { get; set; }
        private string _destination { get; set; }
        private MsgsApps _msgsApps { get; set; }
        private ProcessInvoke Invoke { get; set; }
        public TeamViewer()
        {
            _msgsApps = new MsgsApps();
            _userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            _destination = Path.Combine(_userProfile, "Downloads\\");
        }

        private bool ExecutableExist()
        {
<<<<<<< HEAD

=======
            //If file exists
>>>>>>> 6596a7ebb1cf3dfc5e7138c4760dc9b2725ea4cb
            _exists = new Exists(@"c:\", "TeamViewer.exe");
            return _exists.SearchCheckFileExist();
        }
        private void Uninstall(string uninstallString)
        {
            _installUninstall = new InstUninst();
            _msgsApps.CleanMsgs();
            _msgsApps.WriteMsg("Team Viewer, foi encontrado e esta sendo " +
             "desinstalado. Por favor, aguarde!");
            _installUninstall.Uninstall(uninstallString, "/S");
        }
        private bool UninstallAction()
        {
            bool uninstalled = false;
            _installUninstall = new InstUninst();
            string uninstallString = _installUninstall.GetStringUninstall("TeamViewer", "LocalMachine", @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "UninstallString");
<<<<<<< HEAD
=======

>>>>>>> 6596a7ebb1cf3dfc5e7138c4760dc9b2725ea4cb
            if (ExecutableExist())
            {
                _msgsApps.WriteMsg("Localizando alguma instalação do Team Viewer. Por favor, aguarde!");
                Uninstall(uninstallString);

                do
                {
                }

                while (ExecutableExist());
                uninstalled = true;

            }
<<<<<<< HEAD
=======

>>>>>>> 6596a7ebb1cf3dfc5e7138c4760dc9b2725ea4cb
            return uninstalled;
        }
        private async Task GetOnlineExecutableAndInstall()
        {
            _destination = Path.Combine(_userProfile, "Downloads\\");
            _installUninstall = new InstUninst();
            await _installUninstall.AppOnline("https://dl.teamviewer.com/download/version_15x/TeamViewer_Setup.exe", _destination + "TVInstall.exe", "/S");
            InstallNow();

        }
        private void InstallNow()
        {
<<<<<<< HEAD
            _installUninstall = new InstUninst(_destination + "\\TVInstall.exe", "/S");
=======
            _installUninstall = new InstUninst(@"c:\users\marcus\Downloads\TVInstall.exe", "/S");
            
>>>>>>> 6596a7ebb1cf3dfc5e7138c4760dc9b2725ea4cb
            _msgsApps.WriteMsg("Instalando, Team Viewer. Por favor, aguarde!");
            _installUninstall.App();
            _msgsApps.CleanMsgs();
            _installUninstall = new InstUninst(@"C:\Program Files (x86)\TeamViewer\TeamViewer.exe", "");
            _installUninstall.App();
            _msgsApps.WriteMsg("Instalado, Abra o ícone azul com o nome TeamViewer em sua área de trabalho. Por favor!");
<<<<<<< HEAD
            Console.ReadKey();
=======


            Console.ReadKey();

           
   
>>>>>>> 6596a7ebb1cf3dfc5e7138c4760dc9b2725ea4cb
        }
        public async Task TeamViewerFix()
        {
            if (UninstallAction())
            {
                await GetOnlineExecutableAndInstall();
            }
            else
            {
                await GetOnlineExecutableAndInstall();
            }
        }
    }
}
