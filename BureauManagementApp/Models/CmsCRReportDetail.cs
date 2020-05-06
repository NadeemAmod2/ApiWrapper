using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class CmsCRReportDetail
    {
        public string CompanyNACMID { get; set; } = "";
        public CmsCRReportDetail_CRSubject CRSubject { get; set; }
        public CmsCRReportDetail_MiscComments MiscComments { get; set; }
        public CmsCRReportDetail_Corporate Corporate { get; set; }
        public CmsCRReportDetail_Officer Officer { get; set; }
        public CmsCRReportDetail_CRInqHist CRInqHist { get; set; }
        public CmsCRReportDetail_Tradeline Tradeline { get; set; }
        public CmsCRReportDetail_Trends Trends { get; set; }
        public CmsCRReportDetail_PublicRecords PublicRecords { get; set; }
        public CmsCRReportDetail_Bankruptcy Bankruptcy { get; set; }
        public CmsCRReportDetail_Alert Alert { get; set; }
        public CmsCRReportDetail_UCCFilings UCCFilings { get; set; }
        public CmsCRReportDetail_FinancialInstitution FinancialInstitution { get; set; }
        public CmsCRReportDetail_Claims Claims { get; set; }
        public CmsCRReportDetail_RequestingMember RequestingMember { get; set; }
        public string Message { get; set; } = "";

        public CmsCRReportDetail() { }
        public CmsCRReportDetail(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CompanyNACMID");
            if (node != null)
            {
                CompanyNACMID = node.InnerText.Trim();
            }
            CRSubject = new CmsCRReportDetail_CRSubject();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/Name");
            if (node != null)
            {
                CRSubject.Name = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/Addr1");
            if (node != null)
            {
                CRSubject.Addr1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/Addr2");
            if (node != null)
            {
                CRSubject.Addr2 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/City");
            if (node != null)
            {
                CRSubject.City = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/State");
            if (node != null)
            {
                CRSubject.State = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/Zip");
            if (node != null)
            {
                CRSubject.Zip = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/Phone");
            if (node != null)
            {
                CRSubject.Phone = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRSubject/InFile");
            if (node != null)
            {
                CRSubject.InFile = node.InnerText.Trim();
            }
            MiscComments = new CmsCRReportDetail_MiscComments();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/MiscComments/SeqNo");
            if (node != null)
            {
                MiscComments.SeqNo = Convert.ToInt32(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/MiscComments/Text");
            if (node != null)
            {
                MiscComments.Text = node.InnerText.Trim();
            }
            Corporate = new CmsCRReportDetail_Corporate();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/CorporateName");
            if (node != null)
            {
                Corporate.CorporateName = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/CorporateAddress");
            if (node != null)
            {
                Corporate.CorporateAddress = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/IncorporatedDate");
            if (node != null)
            {
                Corporate.IncorporatedDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/CorporateStatus");
            if (node != null)
            {
                Corporate.CorporateStatus = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/FileDate");
            if (node != null)
            {
                Corporate.FileDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/DocumentNo");
            if (node != null)
            {
                Corporate.DocumentNo = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/Agent");
            if (node != null)
            {
                Corporate.Agent = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Corporate/Comment");
            if (node != null)
            {
                Corporate.Comment = node.InnerText.Trim();
            }
            Officer = new CmsCRReportDetail_Officer();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Officer/Title");
            if (node != null)
            {
                Officer.Title = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Officer/Name");
            if (node != null)
            {
                Officer.Name = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Officer/Address");
            if (node != null)
            {
                Officer.Address = node.InnerText.Trim();
            }
            CRInqHist = new CmsCRReportDetail_CRInqHist();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRInqHist/Industry");
            if (node != null)
            {
                CRInqHist.Industry = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/CRInqHist/Date");
            if (node != null)
            {
                CRInqHist.Date = DateTime.Parse(node.InnerText.Trim());
            }
            Tradeline = new CmsCRReportDetail_Tradeline();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/SourceID");
            if (node != null)
            {
                Tradeline.SourceID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/IndType");
            if (node != null)
            {
                Tradeline.IndType = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/OpenDate");
            if (node != null)
            {
                Tradeline.OpenDate = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/LastSale");
            if (node != null)
            {
                Tradeline.LastSale = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/ReportDate");
            if (node != null)
            {
                Tradeline.ReportDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/TotalDue");
            if (node != null)
            {
                Tradeline.TotalDue = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/HighCredit");
            if (node != null)
            {
                Tradeline.HighCredit = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/Current");
            if (node != null)
            {
                Tradeline.Current = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/PD30Day");
            if (node != null)
            {
                Tradeline.PD30Day = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/PD60Day");
            if (node != null)
            {
                Tradeline.PD60Day = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/PD90Day");
            if (node != null)
            {
                Tradeline.PD90Day = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/PD120Day");
            if (node != null)
            {
                Tradeline.PD120Day = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/Comment");
            if (node != null)
            {
                Tradeline.Comment = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/AvgDays");
            if (node != null)
            {
                Tradeline.AvgDays = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Tradeline/Region");
            if (node != null)
            {
                Tradeline.Region = node.InnerText.Trim();
            }
            Trends = new CmsCRReportDetail_Trends();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/Period");
            if (node != null)
            {
                Trends.Period = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/LineCnt");
            if (node != null)
            {
                Trends.LineCnt = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/TotalDue");
            if (node != null)
            {
                Trends.TotalDue = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/CurrentPct");
            if (node != null)
            {
                Trends.CurrentPct = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/PD30DayPct");
            if (node != null)
            {
                Trends.PD30DayPct = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/PD60DayPct");
            if (node != null)
            {
                Trends.PD60DayPct = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/PD90DayPct");
            if (node != null)
            {
                Trends.PD90DayPct = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Trends/PD120DayPct");
            if (node != null)
            {
                Trends.PD120DayPct = node.InnerText.Trim();
            }
            PublicRecords = new CmsCRReportDetail_PublicRecords();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Date");
            if (node != null)
            {
                PublicRecords.Date = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Type");
            if (node != null)
            {
                PublicRecords.Type = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/County");
            if (node != null)
            {
                PublicRecords.County = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Book");
            if (node != null)
            {
                PublicRecords.Book = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Page");
            if (node != null)
            {
                PublicRecords.Page = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Lienor");
            if (node != null)
            {
                PublicRecords.Lienor = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Amount");
            if (node != null)
            {
                PublicRecords.Amount = Convert.ToInt64(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/Property");
            if (node != null)
            {
                PublicRecords.Property = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/SatisDate");
            if (node != null)
            {
                PublicRecords.SatisDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/SatisBook");
            if (node != null)
            {
                PublicRecords.SatisBook = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/PublicRecords/SatisPage");
            if (node != null)
            {
                PublicRecords.SatisPage = node.InnerText.Trim();
            }
            Bankruptcy = new CmsCRReportDetail_Bankruptcy();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Bankruptcy/Date");
            if (node != null)
            {
                Bankruptcy.Date = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Bankruptcy/Case");
            if (node != null)
            {
                Bankruptcy.Case = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Bankruptcy/Chapter");
            if (node != null)
            {
                Bankruptcy.Chapter = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Bankruptcy/Attorney");
            if (node != null)
            {
                Bankruptcy.Attorney = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Bankruptcy/Comment");
            if (node != null)
            {
                Bankruptcy.Comment = node.InnerText.Trim();
            }
            Alert = new CmsCRReportDetail_Alert();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/SourceID");
            if (node != null)
            {
                Alert.SourceID= node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/IndType");
            if (node != null)
            {
                Alert.IndType = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/Date");
            if (node != null)
            {
                Alert.Date = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/Type");
            if (node != null)
            {
                Alert.Type = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/Amount");
            if (node != null)
            {
                Alert.Amount = Convert.ToDouble(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/Comment");
            if (node != null)
            {
                Alert.Comment = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Alert/Region");
            if (node != null)
            {
                Alert.Region = node.InnerText.Trim();
            }
            UCCFilings = new CmsCRReportDetail_UCCFilings();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/UCCFilings/Account");
            if (node != null)
            {
                UCCFilings.Account = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/UCCFilings/Date");
            if (node != null)
            {
                UCCFilings.Date = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/UCCFilings/Expires");
            if (node != null)
            {
                UCCFilings.Expires = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/UCCFilings/Security");
            if (node != null)
            {
                UCCFilings.Security = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/UCCFilings/SecurityAddress");
            if (node != null)
            {
                UCCFilings.SecurityAddress = node.InnerText.Trim();
            }
            FinancialInstitution = new CmsCRReportDetail_FinancialInstitution();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/Source");
            if (node != null)
            {
                FinancialInstitution.Source = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/OpenSince");
            if (node != null)
            {
                FinancialInstitution.OpenSince = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/AcctType");
            if (node != null)
            {
                FinancialInstitution.AcctType = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/ReportDate");
            if (node != null)
            {
                FinancialInstitution.ReportDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/OpenFigures");
            if (node != null)
            {
                FinancialInstitution.OpenFigures = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/CurrFigures");
            if (node != null)
            {
                FinancialInstitution.CurrFigures = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/FinancialInstitution/Comment");
            if (node != null)
            {
                FinancialInstitution.Comment = node.InnerText.Trim();
            }
            Claims = new CmsCRReportDetail_Claims();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/MemberNo");
            if (node != null)
            {
                Claims.MemberNo = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/IndType");
            if (node != null)
            {
                Claims.IndType = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/EntryDate");
            if (node != null)
            {
                Claims.EntryDate = DateTime.Parse(node.InnerText.Trim());
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/Status");
            if (node != null)
            {
                Claims.Status = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/ClaimAmt");
            if (node != null)
            {
                Claims.ClaimAmt = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/ClaimBalance");
            if (node != null)
            {
                Claims.ClaimBalance = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Claims/Region");
            if (node != null)
            {
                Claims.Region = node.InnerText.Trim();
            }
            RequestingMember = new CmsCRReportDetail_RequestingMember();
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/MemberNo");
            if (node != null)
            {
                RequestingMember.MemberNo = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/Name");
            if (node != null)
            {
                RequestingMember.Name = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/Addr1");
            if (node != null)
            {
                RequestingMember.Addr1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/City");
            if (node != null)
            {
                RequestingMember.City = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/State");
            if (node != null)
            {
                RequestingMember.State = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/RequestingMember/Zip");
            if (node != null)
            {
                RequestingMember.Zip = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NACMCms/Response/CmsCRReportDetail/Message");
            if (node != null)
            {
                Message = node.InnerText.Trim();
            }
        }
    }

    public class CmsCRReportDetail_CRSubject
    {
        public string Name { get; set; } = "";
        public string Addr1 { get; set; } = "";
        public string Addr2 { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Phone { get; set; } = "";
        public string InFile { get; set; } = "";
    }
    public class CmsCRReportDetail_MiscComments
    {
        public int SeqNo { get; set; }
        public string Text { get; set; } = "";
    }
    public class CmsCRReportDetail_Corporate
    {
        public string CorporateName { get; set; } = "";
        public string CorporateAddress { get; set; } = "";
        public DateTime IncorporatedDate { get; set; }
        public string CorporateStatus { get; set; } = "";
        public DateTime FileDate { get; set; }
        public string DocumentNo { get; set; } = "";
        public DateTime Updated { get; set; }
        public string Agent { get; set; } = "";
        public string Comment { get; set; } = "";
    }
    public class CmsCRReportDetail_Officer
    {
        public string Title { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address{ get; set; } = "";
    }
    public class CmsCRReportDetail_CRInqHist
    {
        public string Industry { get; set; } = "";
        public DateTime Date{ get; set; }
    }
    public class CmsCRReportDetail_Tradeline
    {
        public string SourceID { get; set; }
        public string IndType { get; set; }
        public string OpenDate { get; set; }
        public string LastSale { get; set; }
        public DateTime ReportDate { get; set; }
        public long TotalDue { get; set; }
        public long HighCredit { get; set; }
        public long Current { get; set; }
        public long PD30Day { get; set; }
        public long PD60Day { get; set; }
        public long PD90Day { get; set; }
        public long PD120Day { get; set; }
        public string Comment{ get; set; }
        public string AvgDays { get; set; }
        public string Region { get; set; }
    }
    public class CmsCRReportDetail_Trends
    {
        public string Period { get; set; }
        public string LineCnt { get; set; }
        public long TotalDue { get; set; }
        public string CurrentPct { get; set; }
        public string PD30DayPct { get; set; }
        public string PD60DayPct { get; set; }
        public string PD90DayPct { get; set; }
        public string PD120DayPct { get; set; }        
    }
    public class CmsCRReportDetail_PublicRecords
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string County { get; set; }
        public string Book { get; set; }
        public string Page { get; set; }
        public string Lienor { get; set; }
        public long Amount{ get; set; }
        public string Property { get; set; }
        public DateTime SatisDate { get; set; }
        public string SatisBook { get; set; }
        public string SatisPage { get; set; }
    }
    public class CmsCRReportDetail_Bankruptcy
    {
        public DateTime Date { get; set; }
        public string Case { get; set; }
        public string Chapter { get; set; }
        public string Attorney { get; set; }
        public string Comment { get; set; }
    }
    public class CmsCRReportDetail_Alert
    {
        public string SourceID{ get; set; }
        public string IndType { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
        public string Region { get; set; }
    }
    public class CmsCRReportDetail_UCCFilings
    {
        public string Account { get; set; }
        public DateTime Date { get; set; }
        public DateTime Expires { get; set; }
        public string Security { get; set; }
        public string SecurityAddress { get; set; }
    }
    public class CmsCRReportDetail_FinancialInstitution
    {
        public string Source { get; set; }
        public string OpenSince { get; set; }
        public string AcctType { get; set; }
        public DateTime ReportDate { get; set; }
        public string OpenFigures { get; set; }
        public string CurrFigures { get; set; }
        public string Comment { get; set; }
    }
    public class CmsCRReportDetail_Claims
    {
        public string MemberNo { get; set; }
        public string IndType { get; set; }
        public DateTime EntryDate { get; set; }
        public string Status { get; set; }
        public string ClaimAmt { get; set; }
        public string ClaimBalance { get; set; }
        public string Region { get; set; }
    }
    public class CmsCRReportDetail_RequestingMember
    {
        public string MemberNo { get; set; }
        public string Name { get; set; }
        public string Addr1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
