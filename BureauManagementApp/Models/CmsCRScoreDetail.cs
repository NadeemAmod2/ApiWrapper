using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class CmsCRScoreDetail
    {
        public string CompanyNACMID { get; set; } = "";
        public string Score { get; set; } = "";
        public string Class { get; set; } = "";
        public string ClassType { get; set; } = "";
        public string Message { get; set; } = "";

        public CmsCRScoreDetail() { }
        public CmsCRScoreDetail(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NACMCms/Response/CmsCRScoreDetail/CompanyNACMID");
            if (node != null)
            {
                CompanyNACMID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRScoreDetail/Score");
            if (node != null)
            {
                Score = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRScoreDetail/Class");
            if (node != null)
            {
                Class = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRScoreDetail/ClassType");
            if (node != null)
            {
                ClassType = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRScoreDetail/Message");
            if (node != null)
            {
                Message = node.InnerText.Trim();
            }
        }
    }
}
