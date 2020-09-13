using System;
using System.Collections.Generic;
using System.Text;

namespace NsTools.Hardware.Basic
{
    class Invocations
    {
        private SystemEngine _engine { get; set; }

        public Invocations()
        {
            _engine = new SystemEngine();
        }

        public string AssMemoryCapacity()
        {
            return _engine.ActMemoryCapacity();
        }



    }
}
