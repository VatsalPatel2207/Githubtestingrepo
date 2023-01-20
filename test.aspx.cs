using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace MyWEB2
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myservice.Connect obj = new myservice.Connect();

            string Entity = "<Entity xmlns=''> <EntityNumber></EntityNumber> <FirstName>Sourabh</FirstName> <LastName>Hello</LastName> <CompanyName>Test Company</CompanyName> <HomePhone>171837711</HomePhone> <EmailAddress>testing1@gmail.com</EmailAddress> <DoNotCall>true</DoNotCall> </Entity>";
            XmlNode xd = obj.PostEntity("002170Test", "LD002170C", "qG5Pf3XTCCoaniDTpLqUCU8i", "123474", Entity);


             
            string str2 = JsonConvert.SerializeXmlNode(xd, Newtonsoft.Json.Formatting.None, true);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(str2);
            XmlNode newNode = doc.DocumentElement;

            MResponse1 mResponse = JsonConvert.DeserializeObject<MResponse1>(str2);
            JObject jObjects1 = JObject.FromObject(mResponse);
            string id = mResponse.EntityID;
            //DataSet ds = ConvertXmlIntoDataset(xd.InnerXml);
            //// strinf id = ds[Response].[]
            //string id = (string)ds.Tables["Response"].Rows[0]["EntityID"];
        }

        public static DataSet ConvertXmlIntoDataset(string xml_Data)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(new StringReader(xml_Data));
            return ds;
        }

    }
}