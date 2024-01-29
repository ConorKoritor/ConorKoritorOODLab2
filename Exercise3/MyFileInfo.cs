using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise3
{
    internal class MyFileInfo
    {
        public string Name { get; set; }
        public long Length {  get; set; }
        public DateTime CreationTime {  get; set; }

        public override string ToString()
        {
            return String.Format("{0,-40}{1,6:F0} MB {2}", Name, Length / 1000, CreationTime.ToShortDateString());
        }
    }
}
