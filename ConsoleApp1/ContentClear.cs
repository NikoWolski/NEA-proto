using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ContentClear
    {
        public ContentClear()
        {
            Clear();
        }
        private void Clear()
        {
            using (StreamWriter sw = new StreamWriter("contents2.txt"))
            {
                sw.Write("");
            }
        }
    }
}
