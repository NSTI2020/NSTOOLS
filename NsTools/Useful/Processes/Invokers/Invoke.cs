﻿using System.Diagnostics;
using System.Threading.Tasks;

namespace NsTools.Useful.Processes
{
    class Invoke
    {
       private ProcessStartInfo _procStartInf { get; set; }
       private string _fName { get; set; }
       private bool _standartOutput { get; set; }
       private bool _shellExecute { get; set; }
       private string _args { get; set; }

        public Invoke(string fName, string args)
        {
            _fName = fName;
            _args = args;
            _procStartInf = new ProcessStartInfo(fName, args);
            _procStartInf.UseShellExecute = true;
        }
        public void InvokeProc()
        {
            Process.Start(_procStartInf).WaitForExit();
        }







    }
}
