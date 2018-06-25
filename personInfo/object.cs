using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInfo
{
    class test
    {
        public void testFunc()
        {
            string str = "{ 'context_name': { 'lower_bound': 'value', 'pper_bound': 'value', 'values': [ 'value1', 'valueN' ] } }";
            var obj1 = JsonConvert.DeserializeObject(str);
           str = JsonConvert.SerializeObject(obj1);
            JObject.Parse(str);
        }
        
    }
}
    

