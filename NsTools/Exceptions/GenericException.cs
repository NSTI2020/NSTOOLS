using System;

namespace NsTools.Exceptions
{
    public class GenericException : ApplicationException
    {
        public GenericException(string msg) : base(msg)
        {

        }
    }

    public class RegistryException : ApplicationException
    {
        public RegistryException(string msg) : base(msg)
        {

        }
    }







}
