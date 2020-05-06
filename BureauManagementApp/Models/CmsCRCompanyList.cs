using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class CmsCRCompanyList
    {
        public string CompanyNACMID { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string ReportContent { get; set; }
        public string Message { get; set; }

        public CmsCRCompanyList() { }
        public CmsCRCompanyList(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/CompanyNACMID");
            if (node != null)
            {
                CompanyNACMID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/CompanyName");
            if (node != null)
            {
                CompanyName = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/AddressLine1");
            if (node != null)
            {
                AddressLine1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/AddressLine2");
            if (node != null)
            {
                AddressLine2 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/City");
            if (node != null)
            {
                City = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/State");
            if (node != null)
            {
                State = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/ZipCode");
            if (node != null)
            {
                ZipCode = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/Country");
            if (node != null)
            {
                Country = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/Telephone");
            if (node != null)
            {
                Telephone = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/ReportContent");
            if (node != null)
            {
                ReportContent = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRCompanyList/Message");
            if (node != null)
            {
                Message = node.InnerText.Trim();
            }
        }
    }
}
