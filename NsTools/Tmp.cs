using System;

namespace NsTools
{
    
    /*
          class RegistryReg
        {

            private List<string> _lstInstalled { get; set; }
            private string _strUninstall { get; set; }
            private string _propertName { get; set; }
            private string _volumeName { get; set; }
            private string _baseRegistry { get; set; }
            private string _registryPath { get; set; }
           private RegistryValueKind _regVKind { get; set; }

            private RegistryKey _tBaseRegistry { get; set; }

            public RegistryReg(string baseRegistry,string registryPath, string propertyName, string volumeName, RegistryValueKind registryValueKind)
            {
                _lstInstalled = new List<string>();
                _baseRegistry = baseRegistry;
                _propertName = propertyName;
                _volumeName = volumeName;
                _registryPath = registryPath;

                _regVKind = registryValueKind;


                if (_baseRegistry.Contains("LocalMachine"))
                {
                    _tBaseRegistry = Registry.LocalMachine.OpenSubKey(registryPath);
                }
                if (_baseRegistry.Contains("CurrentUser"))
                {
                    _tBaseRegistry = Registry.CurrentUser.OpenSubKey(registryPath);
                }
            }


            public void RExe()
            {




            }

            public string SearchUninstallStringExeMsi(string name)
            {
                using (RegistryKey rk = TBaseRegistry)
                {
                    foreach (string skName in rk.GetSubKeyNames())
                    {
                        using (RegistryKey sk = rk.OpenSubKey(skName))
                        {
                            try
                            {
                                if (sk.GetValue(PropertName).ToString().Contains(name))
                                {
                                    return sk.GetValue("UninstallString").ToString();
                                }
                            }
                            catch (Exception)
                            { }
                        }
                    }
                }
                return strUninstall;
            }










            public List<string> test(string name)
            {
                using (RegistryKey rk = TBaseRegistry)
                {
                    foreach (string skName in rk.GetSubKeyNames())
                    {
                        if (skName.Contains(name))
                        {
                            using (RegistryKey sk = rk.OpenSubKey(skName))
                            {
                                try
                                {
                                    lstInstalled.Add(sk.GetValue(PropertName).ToString());
                                }
                                catch (Exception)
                                { }
                            }
                        }
                    }
                }



                return lstInstalled;
            }


}




     */


}