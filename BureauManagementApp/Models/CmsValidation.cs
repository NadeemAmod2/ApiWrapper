using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class CmsValidation
    {
        public string ValidationKey { get; set; } = "";
        public string Message { get; set; } = "";

        public CmsValidation() { }
        public CmsValidation(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NACMCms/Response/CmsValidation/ValidationKey");
            if (node != null)
            {
                ValidationKey = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsValidation/Message");
            if (node != null)
            {
                Message = node.InnerText.Trim();
            }
        }
    }
}
