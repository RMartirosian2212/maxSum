using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum
{
    public class Reading
    {
        public string[] Read(string path)
        {
            string[] str = File.ReadAllLines(path);
            return str;
        }
    }
}
