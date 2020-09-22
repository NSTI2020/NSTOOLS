using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;

namespace NsTools.Useful
{
    class Zip
    {
        private string  Source { get; set; }
        private string Target { get; set; }

        public Zip(string source, string target)
        {
            Source = source;
            Target = target;
        }

        public void Unzip()
        {
            ZipFile.ExtractToDirectory(Source, Target);
        }




    }
}
