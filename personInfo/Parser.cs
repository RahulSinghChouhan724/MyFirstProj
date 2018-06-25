using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personInfo
{
    public class Parser
    {
        public Data ParserConfig(string json)
        {
            // convert string to json array
            var a = JArray.Parse(json);

            // initialize return object
            var result = new Data();

            // loop through each item in the json array
            foreach (var i in a)
            {
                // extract the source name
                var s = i["source"].ToString();

                Source b = null;

                // check if bucket of above sourcename exist
                if (result.Sources.ContainsKey(s))
                {
                    // the bucket exists


                    // get existing bucket

                }
                else
                {
                    // the bucket do not exist
                    
                    // create bucket
                    var b = new Source
                    {
                        Name = s
                    };

                    result.Sources.Add(s, b);
                }


                // extract field name


                // add filedt name to the bucket
            }

            return result;
        }
    }
}
