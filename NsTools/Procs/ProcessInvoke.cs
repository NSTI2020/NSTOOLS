using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NsTools.Procs
{
    class ProcessInvoke
    {
       private ProcessStartInfo ProcStartInf { get; set; }
       private string FName { get; set; }
       private bool StandartOutput { get; set; }
       private bool ShellExecute { get; set; }
       private string Args { get; set; }


        public ProcessInvoke(string fName, string args)
        {
            FName = fName;
            Args = args;
            ProcStartInf = new ProcessStartInfo(fName, args);
            
        }

        public void InvokeProc()
        {
            Process.Start(ProcStartInf).WaitForExit();
        }


    }
}
