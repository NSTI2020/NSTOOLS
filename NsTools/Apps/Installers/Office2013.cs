using NsTools.Installer;
using NsTools.Useful;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NsTools.Apps.Installers
{
    class Office2013
    {
        private Tools tools;
        private InstUninst _installUninstall;
        private string _destination;
        private string _source;
        private string _proFile;
        private string _setupExe;

        public Office2013()
        {
            tools = new Tools();
            _installUninstall = new InstUninst();
            _source = tools.Paths("ZipFile");
            _proFile = tools.Paths("UserProfile");
            _destination = tools.Paths("Downloads");
            _setupExe = tools.Paths("SetupExe");
        }

        public async Task DownloadOff2013()
        {
            await _installUninstall.AppOnline("http://www.nostopti.com/tvirtual/toolbox/instalations/office2013.zip", _destination + @"\Office2013.zip");
            ExtractOffice2013();
        }
        public void ExtractOffice2013()
        {
            Zip zip = new Zip(_source, _proFile);
            zip.Unzip();
        }

        public void InstallOffice2013()
        {
            InstUninst install = new InstUninst(_setupExe, " /AdminFile auto.msp");
            install.App();
        }

    }
}
