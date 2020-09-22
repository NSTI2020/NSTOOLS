using System;
using System.Collections.Generic;
using System.Text;

namespace NsTools.Useful
{
    public class Tools
    {
        private string  _profile { get; set; }
        private string  _downloadPath { get; set; }
        private string  _setupOfficePathExtracted { get; set; }
        public string _zipOffice2013 { get; set; }
        public string _SetupExeOffice2013 { get; set; }

        public Tools()
        {
            _profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            _downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            _setupOfficePathExtracted = _profile + @"\Office2013";
            _zipOffice2013 = _downloadPath + @"\Office2013.zip";
            _SetupExeOffice2013 = _setupOfficePathExtracted + @"\setup.exe";

        }
        public string Paths(string path)
        {
            switch (path)
            {
                case "UserProfile":
                    return _profile;
                case "Downloads":
                    return _downloadPath;
                case "Office2013ExtractedPath":
                    return _setupOfficePathExtracted;
                case "ZipFile":
                    return _zipOffice2013;
                case "SetupExe":
                    return _SetupExeOffice2013;
            }
            return "Inexistente";
        }          

    }
    
}

   

        
       
