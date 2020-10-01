using System.Diagnostics;

namespace NsTools.Useful.Processes.Handle
{
    class Handle
    {
        private Process[] Processes { get; set; }
        private bool Killed { get; set; }
        public Handle()
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
