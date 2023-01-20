using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
 
namespace MyWEB2
{
    public class Temp
    {
        static void Main(string[] args)
        {
            myservice.Connect obj = new myservice.Connect();
            
            string Entity = "<Entity xmlns=''> <EntityNumber></EntityNumber> <FirstName>Sourabh</FirstName> <LastName>Hello</LastName> <CompanyName>Test Company</CompanyName> <HomePhone>171837711</HomePhone> <EmailAddress>testing1@gmail.com</EmailAddress> <DoNotCall>true</DoNotCall> </Entity>";
            XmlNode xd = obj.PostEntity("002170Test", "LD002170C", "qG5Pf3XTCCoaniDTpLqUCU8i", "123474", Entity);
        }
    }
}