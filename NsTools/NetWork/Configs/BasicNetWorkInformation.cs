
using System.Collections.Generic;

namespace NsTools.NetWork.Configs
{
    public class BasicNetWorkInformation
    {
        public Ip ip { get; set; }

        public BasicNetWorkInformation()
        {
          ip = new Ip();
        }
        //Get IP address of  network adapter active
        public List<string> ShowIp()
        {
            return ip.GetIP();
        }

        public List<string> ShowDefaulGatway()
        {
            return ip.GetDefaultGatway();
        }
        public List<string> Domain()
        {
            return ip.Domain();
        }
        public List<string> Dns()
        {
            return ip.Dns();
        }

        public string AssDhcpServer()
        {
            return ip.ActDhcpServer();
        }
        public string AssActiveAdapterName()
        {
            return ip.ActActiveAdapterName();
        }
        public string AssMac()
        {
            return ip.Mac();
        }

        public bool AssDhcpEnabled()
        {
            return ip.ActDhcpEnabled();
        }
        public override string ToString()
        {
            return "IP: " + ShowIp() +
                   " GATWAY: " + ShowDefaulGatway();
              
        }






    }
}
