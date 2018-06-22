using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInfo
{
    public class Source
    {
        public string Name { get; set; }

        public IList<Field> Fields { get; set; }
    }
}
