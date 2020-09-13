using NsTools.Useful;
using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace NsTools.Hardware.Basic
{
    class SystemEngine
    {
        private ManagementObjectSearcher _objSearch { get; set; }
        private UInt64 _listReturnOne { get; set; }
        private List<UInt64> _listReturn { get; set; }
        private Converters _converter { get; set; }
        public SystemEngine()
        {
            _listReturn = new List<UInt64>();
            _converter = new Converters();
        }



        public List<UInt64> OperatorMObjReturnsManyUint64(string strWmi, string property)
        {
            _objSearch = new ManagementObjectSearcher(new ObjectQuery(strWmi));
            ManagementObjectCollection queryCollection = _objSearch.Get();
            foreach (var qwe in queryCollection)
            {
                PropertyData data1 = qwe.Properties[property];
                UInt64[] T = (UInt64[])data1.Value;
                foreach (UInt64 item in T)
                {
                    _listReturn.Add(item);
                }
                break;
            }
            return _listReturn;
        }
        public UInt64 OperatorMObjReturnsOneUint64(string strWmi, string property)
        {
            _objSearch = new ManagementObjectSearcher(new ObjectQuery(strWmi));
            ManagementObjectCollection queryCollection = _objSearch.Get();
            foreach (var qwe in queryCollection)
            {
                PropertyData data1 = qwe.Properties[property];
                UInt64 T = (UInt64)data1.Value;
                _listReturnOne = T;
                break;
            }
            return _listReturnOne;
        }

        public string ActMemoryCapacity()
        {
            return _converter.ConvertSize(OperatorMObjReturnsOneUint64("SELECT * FROM Win32_ComputerSystem", "TotalPhysicalMemory"));
        }
        



    }
}
