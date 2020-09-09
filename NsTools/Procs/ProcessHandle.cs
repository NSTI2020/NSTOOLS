using System.Diagnostics;
namespace NsTools.Procs
{
    class ProcessHandle
    {
        private Process[] Processes { get; set; }
        private bool Killed { get; set; }
        public ProcessHandle()
        {

        }

        public bool KillProcessByName(string name)
        {
            Killed = false;
            Processes = Process.GetProcessesByName(name);
            foreach (Process p in Processes)
            {
                while (!p.HasExited)
                {
                    p.Kill();
                    Killed = true;
                } 
            }
            return Killed;
        }
    }
}
