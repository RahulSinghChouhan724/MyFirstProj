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
            return new Data
            {
                Sources = new Dictionary<string, Source>
                {
                    { "google", new Source{
                        Name = "google",
                        Fields = new Dictionary<string, Field>
                        {
                            { "FullName", new Field
                            {
                                Name = "FullName",
                            }
                            },{ "Age", new Field
                            {
                                Name = "Age",
                            }
                            }
                    } }
                },{ "linkedIn", new Source{
                        Name = "linkedIn",
                        Fields = new Dictionary<string, Field>
                        {
                            { "MaxQual", new Field
                            {
                                Name = "MaxQual",
                            }
                            }
                    } }
                }
                }
            };
        }
    }
}
