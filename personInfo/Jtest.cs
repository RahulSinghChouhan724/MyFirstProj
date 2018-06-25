using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace personInfo
{
   public class Jtest

    {
        public void info()
        {

                //DECLARE JSON VARIALBLE
                string data = @"{'FirstName':'Rahul','LastName':'Singh'}";

                //Deserialize
                var MyDetails = JsonConvert.DeserializeObject<MyDetail>(data);
                Console.WriteLine(String.Concat("Hi", MyDetails.FirstName, " " + MyDetails.LastName));
                Console.ReadLine();

        }


            public class MyDetail
        {
            public String FirstName
            {
                get;
                set;
            }

            public String LastName
            {
                get;
                set;
            }

        }

               
    }
  }
    