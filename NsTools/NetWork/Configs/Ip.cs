using System.Collections.Generic;
using System.Linq;
using System.Management;


namespace NsTools.NetWork.Configs
{
    public class Ip
    {
        private ManagementObjectSearcher _objSearch { get; set; }
        private string _OneReturn { get; set; }

        private List<string> _listReturn { get; set; }

        public Ip()
        {
            _listReturn = new List<string>();
        }
        public string OperatorMObjReturnsOne(string strWmi, string property)
        {
           _objSearch  = new ManagementObjectSearcher(new ObjectQuery(strWmi));
            ManagementObjectCollection queryCollection = _objSearch.Get();
            foreach (var qwe in queryCollection)
            {
                PropertyData data1 = qwe.Properties[property];
                string T = (string)data1.Value;

                _OneReturn = T;
        
                break;
            }
            return _OneReturn;
        }
        public List<string> OperatorMObjReturnsMany(string strWmi, string property)
        {
            _objSearch = new ManagementObjectSearcher(new ObjectQuery(strWmi));
            ManagementObjectCollection queryCollection = _objSearch.Get();
            foreach (var qwe in queryCollection)
            {
                PropertyData data1 = qwe.Properties[property];
                string[] T = (string[])data1.Value;
                foreach (string item in T)
                {
                    _listReturn.Add(item);
                }
                break;
            }
            return _listReturn;
        }
        public List<string> GetIP()
        {
            return OperatorMObjReturnsMany("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "IpAddress");
        }
        public string ActActiveAdapterName()
        {
            return OperatorMObjReturnsOne("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "Caption");
        }
        public List<string> GetDefaultGatway()
        {
            return OperatorMObjReturnsMany("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "DefaultIPGateway");
        }
        public List<string> Domain()
        {
            _listReturn = OperatorMObjReturnsMany("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "DNSDomainSuffixSearchOrder");
            return _listReturn;
        }
        public List<string> Dns()
        {
            _listReturn = OperatorMObjReturnsMany("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "DNSServerSearchOrder");
            return _listReturn;
        }
        public List<string> SubNetMask()
        {
            _listReturn = OperatorMObjReturnsMany("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "IPSubnet");
            return _listReturn;
        }
        public string ActDhcpServer()
        {
            _OneReturn = OperatorMObjReturnsOne("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'", "DHCPServer");
            return _OneReturn;
        }

    }
}
