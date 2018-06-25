using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInfo
{
    public class Data
    {
        public IDictionary<string, Source> Sources { get; set; }

        public Data()
        {
            Sources = new Dictionary<string, Source>();
        }
    }
}
