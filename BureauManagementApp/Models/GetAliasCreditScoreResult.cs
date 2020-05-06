using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class GetAliasCreditScoreResult
    {
        public string DebtorID { get; set; } = "";
        public string AccountID { get; set; } = "";
        public string AccountCode { get; set; } = "";
        public string AccountName { get; set; } = "";
        public string BusAddr1 { get; set; } = "";
        public string BusCity { get; set; } = "";
        public string BusState { get; set; } = "";
        public string CreditScore { get; set; } = "";
        public string LowCreditScore { get; set; } = "";
        public string HighCreditScore { get; set; } = "";
        public string RecentHigh12 { get; set; } = "";
        public string TotalBalance { get; set; } = "";
        public string CurrentPastDueBalance { get; set; } = "";
        public string PDBalance { get; set; } = "";
        public string CurrentPastDuePercentage { get; set; } = "";
        public string AccountsIncluded { get; set; } = "";
        public string Contributors{ get; set; } = "";
        public string PDCount { get; set; } = "";
        public string EarliestAccount { get; set; } = "";
        public string CreditReportLink { get; set; } = "";

        public GetAliasCreditScoreResult() { }
        public GetAliasCreditScoreResult(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NewDataSet/Table/DEBTOR_ID");
            if (node != null)
            {
                DebtorID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/ACCOUNT_ID");
            if (node != null)
            {
                AccountID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/ACCOUNT_CODE");
            if (node != null)
            {
                AccountCode = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/ACCOUNT_NAME");
            if (node != null)
            {
                AccountName = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/BUS_ADDR1");
            if (node != null)
            {
                BusAddr1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/BUS_CITY");
            if (node != null)
            {
                BusCity = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/BUS_STATE");
            if (node != null)
            {
                BusState = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/CREDIT_SCORE");
            if (node != null)
            {
                CreditScore = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/LOW_CREDIT_SCORE");
            if (node != null)
            {
                LowCreditScore = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/HIGH_CREDIT_SCORE");
            if (node != null)
            {
                HighCreditScore = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/RECENT_HIGH_12");
            if (node != null)
            {
                RecentHigh12 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/TOTAL_BALANCE");
            if (node != null)
            {
                TotalBalance = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/CURRENT_PAST_DUE_BALANCE");
            if (node != null)
            {
                CurrentPastDueBalance = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/PD_BALANCE");
            if (node != null)
            {
                PDBalance = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/CURRENT_PAST_DUE_PERCENTAGE");
            if (node != null)
            {
                CurrentPastDuePercentage = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/ACCOUNTS_INCLUDED");
            if (node != null)
            {
                AccountsIncluded = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/CONTRIBUTORS");
            if (node != null)
            {
                Contributors = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/PD_COUNT");
            if (node != null)
            {
                PDCount = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/EARLIEST_ACCOUNT");
            if (node != null)
            {
                EarliestAccount = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode("NewDataSet/Table/CREDIT_REPORT_LINK");
            if (node != null)
            {
                CreditReportLink = node.InnerText.Trim();
            }
        }
    }
}
