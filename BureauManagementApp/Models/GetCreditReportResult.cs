using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class GetCreditReportResult
    {
        public string ID { get; set; } = "";
        public List<GetCreditReportResult_Account> Account;
        public List<GetCreditReportResult_ARSnapshot> ARSnapshot;
        public List<GetCreditReportResult_RecentHigh> RecentHigh;
        public List<GetCreditReportResult_ARHistorical> ARHistorical;
        public List<GetCreditReportResult_RiskAlert> RiskAlert;
        public List<GetCreditReportResult_RecentInquiries> RecentInquiries;
        public List<GetCreditReportResult_CreditScore> CreditScore;
        public List<GetCreditReportResult_CreditLimit> CreditLimit;

        public GetCreditReportResult() { }
        public GetCreditReportResult(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode("NewDataSet/CREDIT_REPORT/ID");
            if (node != null)
            {
                ID = node.InnerText.Trim();
            }
            Account = new List<GetCreditReportResult_Account>();
            XmlNodeList nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/ACCOUNT");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_Account eachAccount = new GetCreditReportResult_Account();
                node = eachNode.SelectSingleNode("/ACCOUNT_ID");
                if (node != null)
                {
                    eachAccount.ACCOUNT_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DIVISION_ACCOUNT_NUMBER");
                if (node != null)
                {
                    eachAccount.DIVISION_ACCOUNT_NUMBER = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXTRACT_DATE");
                if (node != null)
                {
                    eachAccount.EXTRACT_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_NAME");
                if (node != null)
                {
                    eachAccount.ACCOUNT_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CONTACT_NAME");
                if (node != null)
                {
                    eachAccount.CONTACT_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ADDR1");
                if (node != null)
                {
                    eachAccount.BUS_ADDR1 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ADDR2");
                if (node != null)
                {
                    eachAccount.BUS_ADDR2 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_CITY");
                if (node != null)
                {
                    eachAccount.BUS_CITY = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_STATE");
                if (node != null)
                {
                    eachAccount.BUS_STATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ZIPCODE");
                if (node != null)
                {
                    eachAccount.BUS_ZIPCODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_PHONE1");
                if (node != null)
                {
                    eachAccount.BUS_PHONE1 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_FAX");
                if (node != null)
                {
                    eachAccount.BUS_FAX = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RISK_IND");
                if (node != null)
                {
                    eachAccount.RISK_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/MEETING_IND");
                if (node != null)
                {
                    eachAccount.MEETING_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/PRIME_ACCOUNT");
                if (node != null)
                {
                    eachAccount.PRIME_ACCOUNT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CHECKED");
                if (node != null)
                {
                    eachAccount.CHECKED = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DEBTOR_IND");
                if (node != null)
                {
                    eachAccount.DEBTOR_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DEBTOR_NAME");
                if (node != null)
                {
                    eachAccount.DEBTOR_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SOURCE_CODE");
                if (node != null)
                {
                    eachAccount.SOURCE_CODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DATE_CREATED");
                if (node != null)
                {
                    eachAccount.DATE_CREATED = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/PRIORITY_CODE");
                if (node != null)
                {
                    eachAccount.PRIORITY_CODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BLACKLIST_ADDRESS_IND");
                if (node != null)
                {
                    eachAccount.BLACKLIST_ADDRESS_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BLACKLIST_PHONE_IND");
                if (node != null)
                {
                    eachAccount.BLACKLIST_PHONE_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/END_USER_ID_REMOVE");
                if (node != null)
                {
                    eachAccount.END_USER_ID_REMOVE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/END_USER_NAME_FLAGGED");
                if (node != null)
                {
                    eachAccount.END_USER_NAME_FLAGGED = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME_FLAGGED");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME_FLAGGED = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_ID_SUBMIT");
                if (node != null)
                {
                    eachAccount.COMPANY_ID_SUBMIT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SHOW_CUSTOMER_NUMBER_ON_PACKET");
                if (node != null)
                {
                    eachAccount.SHOW_CUSTOMER_NUMBER_ON_PACKET = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_ADDRESS_ERROR_CODES");
                if (node != null)
                {
                    eachAccount.ACCOUNT_ADDRESS_ERROR_CODES = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/PRIORITY_DECODE");
                if (node != null)
                {
                    eachAccount.PRIORITY_DECODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                Account.Add(eachAccount);
            }

            ARSnapshot = new List<GetCreditReportResult_ARSnapshot>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/AR_SNAPSHOT");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_ARSnapshot eachAccount = new GetCreditReportResult_ARSnapshot();
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SOLD_SINCE");
                if (node != null)
                {
                    eachAccount.SOLD_SINCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXTRACT_DATE");
                if (node != null)
                {
                    eachAccount.EXTRACT_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/LAST_ACTIVITY");
                if (node != null)
                {
                    eachAccount.LAST_ACTIVITY = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_CODES");
                if (node != null)
                {
                    eachAccount.CREDIT_CODES = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_BALANCE");
                if (node != null)
                {
                    eachAccount.ACCOUNT_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_DUE");
                if (node != null)
                {
                    eachAccount.CURRENT_DUE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_30");
                if (node != null)
                {
                    eachAccount.DUE_30 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_60");
                if (node != null)
                {
                    eachAccount.DUE_60 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_90");
                if (node != null)
                {
                    eachAccount.DUE_90 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_91PLUS");
                if (node != null)
                {
                    eachAccount.DUE_91PLUS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMMENT");
                if (node != null)
                {
                    eachAccount.COMMENT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DECODE");
                if (node != null)
                {
                    eachAccount.DECODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                ARSnapshot.Add(eachAccount);
            }

            RecentHigh = new List<GetCreditReportResult_RecentHigh>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/RECENT_HIGH");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_RecentHigh eachAccount = new GetCreditReportResult_RecentHigh();
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SOLD_SINCE");
                if (node != null)
                {
                    eachAccount.SOLD_SINCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXTRACT_DATE");
                if (node != null)
                {
                    eachAccount.EXTRACT_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH_6");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH_6 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH_12");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH_12 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH_24");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH_24 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_BALANCE");
                if (node != null)
                {
                    eachAccount.ACCOUNT_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ALIAS_RECENT_HIGH");
                if (node != null)
                {
                    eachAccount.ALIAS_RECENT_HIGH = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                RecentHigh.Add(eachAccount);
            }

            ARHistorical = new List<GetCreditReportResult_ARHistorical>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/AR_HISTORICAL");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_ARHistorical eachAccount = new GetCreditReportResult_ARHistorical();
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_NAME");
                if (node != null)
                {
                    eachAccount.ACCOUNT_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SOLD_SINCE");
                if (node != null)
                {
                    eachAccount.SOLD_SINCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXTRACT_DATE");
                if (node != null)
                {
                    eachAccount.EXTRACT_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/LAST_ACTIVITY");
                if (node != null)
                {
                    eachAccount.LAST_ACTIVITY = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_CODES");
                if (node != null)
                {
                    eachAccount.CREDIT_CODES = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_HIGH");
                if (node != null)
                {
                    eachAccount.RECENT_HIGH = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_BALANCE");
                if (node != null)
                {
                    eachAccount.ACCOUNT_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_DUE");
                if (node != null)
                {
                    eachAccount.CURRENT_DUE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_30");
                if (node != null)
                {
                    eachAccount.DUE_30 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_60");
                if (node != null)
                {
                    eachAccount.DUE_60 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_90");
                if (node != null)
                {
                    eachAccount.DUE_90 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DUE_91PLUS");
                if (node != null)
                {
                    eachAccount.DUE_91PLUS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMMENT");
                if (node != null)
                {
                    eachAccount.COMMENT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DECODE");
                if (node != null)
                {
                    eachAccount.DECODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                ARHistorical.Add(eachAccount);
            }

            RiskAlert = new List<GetCreditReportResult_RiskAlert>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/RISK_ALERT");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_RiskAlert eachAccount = new GetCreditReportResult_RiskAlert();
                node = eachNode.SelectSingleNode("/RISK_ID");
                if (node != null)
                {
                    eachAccount.CONTRIB_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CONTRIB_DATE");
                if (node != null)
                {
                    eachAccount.CONTRIB_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMMENTS");
                if (node != null)
                {
                    eachAccount.COMMENTS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CATEGORY_CODE");
                if (node != null)
                {
                    eachAccount.CATEGORY_CODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_ID");
                if (node != null)
                {
                    eachAccount.ACCOUNT_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_NAME");
                if (node != null)
                {
                    eachAccount.ACCOUNT_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ADDR1");
                if (node != null)
                {
                    eachAccount.BUS_ADDR1 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ADDR2");
                if (node != null)
                {
                    eachAccount.BUS_ADDR2 = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_CITY");
                if (node != null)
                {
                    eachAccount.BUS_CITY = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_STATE");
                if (node != null)
                {
                    eachAccount.BUS_STATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/BUS_ZIPCODE");
                if (node != null)
                {
                    eachAccount.BUS_ZIPCODE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/MEETING_IND");
                if (node != null)
                {
                    eachAccount.MEETING_IND = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/USER_NAME");
                if (node != null)
                {
                    eachAccount.USER_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/SUBMIT_COMPANY");
                if (node != null)
                {
                    eachAccount.SUBMIT_COMPANY = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RISK_STATUS");
                if (node != null)
                {
                    eachAccount.RISK_STATUS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CHECKED");
                if (node != null)
                {
                    eachAccount.CHECKED = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/TEST");
                if (node != null)
                {
                    eachAccount.TEST = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                RiskAlert.Add(eachAccount);
            }

            CreditScore = new List<GetCreditReportResult_CreditScore>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/CREDIT_SCORE");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_CreditScore eachAccount = new GetCreditReportResult_CreditScore();
                node = eachNode.SelectSingleNode("/SCORE");
                if (node != null)
                {
                    eachAccount.SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_PAST_DUE_PCT");
                if (node != null)
                {
                    eachAccount.CURRENT_PAST_DUE_PCT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_PAST_DUE_AVG");
                if (node != null)
                {
                    eachAccount.CURRENT_PAST_DUE_AVG = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/HISTORY_PAST_DUE_AVG");
                if (node != null)
                {
                    eachAccount.HISTORY_PAST_DUE_AVG = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_AGING_DEBT_DISTRIBUTION_SCORE");
                if (node != null)
                {
                    eachAccount.CURRENT_AGING_DEBT_DISTRIBUTION_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/HISTORICAL_AGING_DEBT_DISTRIBUTION_SCORE");
                if (node != null)
                {
                    eachAccount.HISTORICAL_AGING_DEBT_DISTRIBUTION_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RISK_ALERT_SCORE");
                if (node != null)
                {
                    eachAccount.RISK_ALERT_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/RECENT_INQUIRIES_SCORE");
                if (node != null)
                {
                    eachAccount.RECENT_INQUIRIES_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_PAST_DUE_RATIO");
                if (node != null)
                {
                    eachAccount.CURRENT_PAST_DUE_RATIO = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_PAST_DUE_RATIO");
                if (node != null)
                {
                    eachAccount.CURRENT_PAST_DUE_RATIO = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/HISTORICAL_PAST_DUE_RATIO");
                if (node != null)
                {
                    eachAccount.HISTORICAL_PAST_DUE_RATIO = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_PAST_DUE_BALANCE");
                if (node != null)
                {
                    eachAccount.CURRENT_PAST_DUE_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/HISTORICAL_PAST_DUE_BALANCE");
                if (node != null)
                {
                    eachAccount.HISTORICAL_PAST_DUE_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/TOTAL_CURRENT_LINES");
                if (node != null)
                {
                    eachAccount.TOTAL_CURRENT_LINES = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/TOTAL_HISTORICAL_LINES");
                if (node != null)
                {
                    eachAccount.TOTAL_HISTORICAL_LINES = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/TOTAL_HISTORICAL_LINES_WITH_CREDITS");
                if (node != null)
                {
                    eachAccount.TOTAL_HISTORICAL_LINES_WITH_CREDITS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/TOTAL_HISTORICAL_LINES_WITH_ZERO_BALANCE");
                if (node != null)
                {
                    eachAccount.TOTAL_HISTORICAL_LINES_WITH_ZERO_BALANCE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REASONS");
                if (node != null)
                {
                    eachAccount.REASONS = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/DATA_LENGTH");
                if (node != null)
                {
                    eachAccount.DATA_LENGTH = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/OCS_PROCESSING_TIME");
                if (node != null)
                {
                    eachAccount.OCS_PROCESSING_TIME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXISTING_CREDIT_LIMIT");
                if (node != null)
                {
                    eachAccount.EXISTING_CREDIT_LIMIT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CALCULATED_CREDIT_LINE");
                if (node != null)
                {
                    eachAccount.CALCULATED_CREDIT_LINE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_SCORE");
                if (node != null)
                {
                    eachAccount.CREDIT_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_DUE_PERCENTAGE");
                if (node != null)
                {
                    eachAccount.CURRENT_DUE_PERCENTAGE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_CHECK");
                if (node != null)
                {
                    eachAccount.CREDIT_CHECK = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                CreditScore.Add(eachAccount);
            }

            RecentInquiries = new List<GetCreditReportResult_RecentInquiries>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/RECENT_INQUIRIES");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_RecentInquiries eachAccount = new GetCreditReportResult_RecentInquiries();
                node = eachNode.SelectSingleNode("/ACCOUNT_ID");
                if (node != null)
                {
                    eachAccount.ACCOUNT_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_ID");
                if (node != null)
                {
                    eachAccount.COMPANY_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/ACCOUNT_NAME");
                if (node != null)
                {
                    eachAccount.ACCOUNT_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/INQUIRY_DATE");
                if (node != null)
                {
                    eachAccount.INQUIRY_DATE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/COMPANY_NAME_USER");
                if (node != null)
                {
                    eachAccount.COMPANY_NAME_USER = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/USER_NAME");
                if (node != null)
                {
                    eachAccount.USER_NAME = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                RecentInquiries.Add(eachAccount);
            }

            CreditLimit = new List<GetCreditReportResult_CreditLimit>();
            nodeList = doc.SelectNodes("NewDataSet/CREDIT_REPORT/CREDIT_LIMIT");
            foreach (XmlNode eachNode in nodeList)
            {
                GetCreditReportResult_CreditLimit eachAccount = new GetCreditReportResult_CreditLimit();
                node = eachNode.SelectSingleNode("/DEBTOR_ID");
                if (node != null)
                {
                    eachAccount.DEBTOR_ID = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/EXISTING_CREDIT_LIMIT");
                if (node != null)
                {
                    eachAccount.EXISTING_CREDIT_LIMIT = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_SCORE");
                if (node != null)
                {
                    eachAccount.CREDIT_SCORE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CURRENT_DUE_PERCENTAGE");
                if (node != null)
                {
                    eachAccount.CURRENT_DUE_PERCENTAGE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CALCULATED_CREDIT_LINE");
                if (node != null)
                {
                    eachAccount.CALCULATED_CREDIT_LINE = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/CREDIT_CHECK");
                if (node != null)
                {
                    eachAccount.CREDIT_CHECK = node.InnerText.Trim();
                }
                node = eachNode.SelectSingleNode("/REPORT_ID");
                if (node != null)
                {
                    eachAccount.REPORT_ID = node.InnerText.Trim();
                }

                CreditLimit.Add(eachAccount);
            }
        }
    }

    public class GetCreditReportResult_Account
    {
        public string ACCOUNT_ID { get; set; } = "";
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string DIVISION_ACCOUNT_NUMBER { get; set; } = "";
        public string EXTRACT_DATE { get; set; } = "";
        public string ACCOUNT_NAME { get; set; } = "";
        public string CONTACT_NAME { get; set; } = "";
        public string BUS_ADDR1 { get; set; } = "";
        public string BUS_ADDR2 { get; set; } = "";
        public string BUS_CITY { get; set; } = "";
        public string BUS_STATE { get; set; } = "";
        public string BUS_ZIPCODE { get; set; } = "";
        public string BUS_PHONE1 { get; set; } = "";
        public string BUS_FAX { get; set; } = "";
        public string RISK_IND { get; set; } = "";
        public string MEETING_IND { get; set; } = "";
        public string PRIME_ACCOUNT { get; set; } = "";
        public string CHECKED { get; set; } = "";
        public string DEBTOR_IND { get; set; } = "";
        public string DEBTOR_NAME { get; set; } = "";
        public string SOURCE_CODE { get; set; } = "";
        public string DATE_CREATED { get; set; } = "";
        public string PRIORITY_CODE { get; set; } = "";
        public string BLACKLIST_ADDRESS_IND { get; set; } = "";
        public string BLACKLIST_PHONE_IND { get; set; } = "";
        public string END_USER_ID_REMOVE { get; set; } = "";
        public string END_USER_NAME_FLAGGED { get; set; } = "";
        public string COMPANY_NAME_FLAGGED { get; set; } = "";
        public string COMPANY_ID_SUBMIT { get; set; } = "";
        public string SHOW_CUSTOMER_NUMBER_ON_PACKET { get; set; } = "";
        public string ACCOUNT_ADDRESS_ERROR_CODES { get; set; } = "";
        public string PRIORITY_DECODE { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_ARSnapshot
    {
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string SOLD_SINCE { get; set; } = "";
        public string EXTRACT_DATE { get; set; } = "";
        public string LAST_ACTIVITY { get; set; } = "";
        public string CREDIT_CODES { get; set; } = "";
        public string RECENT_HIGH { get; set; } = "";
        public string ACCOUNT_BALANCE { get; set; } = "";
        public string CURRENT_DUE { get; set; } = "";
        public string DUE_30 { get; set; } = "";
        public string DUE_60 { get; set; } = "";
        public string DUE_90 { get; set; } = "";
        public string DUE_91PLUS { get; set; } = "";
        public string COMMENT { get; set; } = "";
        public string DECODE { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_RecentHigh
    {
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string SOLD_SINCE { get; set; } = "";
        public string EXTRACT_DATE { get; set; } = "";
        public string RECENT_HIGH { get; set; } = "";
        public string RECENT_HIGH_6 { get; set; } = "";
        public string RECENT_HIGH_12 { get; set; } = "";
        public string RECENT_HIGH_24 { get; set; } = "";
        public string ACCOUNT_BALANCE { get; set; } = "";
        public string ALIAS_RECENT_HIGH { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_ARHistorical
    {
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string ACCOUNT_NAME { get; set; } = "";
        public string SOLD_SINCE { get; set; } = "";
        public string EXTRACT_DATE { get; set; } = "";
        public string LAST_ACTIVITY { get; set; } = "";
        public string CREDIT_CODES { get; set; } = "";
        public string RECENT_HIGH { get; set; } = "";
        public string ACCOUNT_BALANCE { get; set; } = "";
        public string CURRENT_DUE { get; set; } = "";
        public string DUE_30 { get; set; } = "";
        public string DUE_60 { get; set; } = "";
        public string DUE_90 { get; set; } = "";
        public string DUE_91PLUS { get; set; } = "";
        public string COMMENT { get; set; } = "";
        public string DECODE { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_RiskAlert
    {
        public string RISK_ID { get; set; } = "";
        public string CONTRIB_DATE { get; set; } = "";
        public string COMMENTS { get; set; } = "";
        public string CATEGORY_CODE { get; set; } = "";
        public string ACCOUNT_ID { get; set; } = "";
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string ACCOUNT_NAME { get; set; } = "";
        public string BUS_ADDR1 { get; set; } = "";
        public string BUS_ADDR2 { get; set; } = "";
        public string BUS_CITY { get; set; } = "";
        public string BUS_STATE { get; set; } = "";
        public string BUS_ZIPCODE { get; set; } = "";
        public string MEETING_IND { get; set; } = "";
        public string USER_NAME { get; set; } = "";
        public string SUBMIT_COMPANY { get; set; } = "";
        public string RISK_STATUS { get; set; } = "";
        public string CHECKED { get; set; } = "";
        public string TEST { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_RecentInquiries
    {
        public string ACCOUNT_ID { get; set; } = "";
        public string COMPANY_ID { get; set; } = "";
        public string COMPANY_NAME { get; set; } = "";
        public string ACCOUNT_NAME { get; set; } = "";
        public string INQUIRY_DATE { get; set; } = "";
        public string COMPANY_NAME_USER { get; set; } = "";
        public string USER_NAME { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_CreditScore
    {
        public string SCORE { get; set; } = "";
        public string CURRENT_PAST_DUE_PCT { get; set; } = "";
        public string CURRENT_PAST_DUE_AVG { get; set; } = "";
        public string HISTORY_PAST_DUE_AVG { get; set; } = "";
        public string CURRENT_AGING_DEBT_DISTRIBUTION_SCORE { get; set; } = "";
        public string HISTORICAL_AGING_DEBT_DISTRIBUTION_SCORE { get; set; } = "";
        public string RISK_ALERT_SCORE { get; set; } = "";
        public string RECENT_INQUIRIES_SCORE { get; set; } = "";
        public string CURRENT_PAST_DUE_RATIO { get; set; } = "";
        public string HISTORICAL_PAST_DUE_RATIO { get; set; } = "";
        public string CURRENT_PAST_DUE_BALANCE { get; set; } = "";
        public string HISTORICAL_PAST_DUE_BALANCE { get; set; } = "";
        public string TOTAL_CURRENT_LINES { get; set; } = "";
        public string TOTAL_HISTORICAL_LINES { get; set; } = "";
        public string TOTAL_HISTORICAL_LINES_WITH_CREDITS { get; set; } = "";
        public string TOTAL_HISTORICAL_LINES_WITH_ZERO_BALANCE { get; set; } = "";
        public string REASONS { get; set; } = "";
        public string DATA_LENGTH { get; set; } = "";
        public string OCS_PROCESSING_TIME { get; set; } = "";
        public string EXISTING_CREDIT_LIMIT { get; set; } = "";
        public string CALCULATED_CREDIT_LINE { get; set; } = "";
        public string CREDIT_SCORE { get; set; } = "";
        public string CURRENT_DUE_PERCENTAGE { get; set; } = "";
        public string CREDIT_CHECK { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
    public class GetCreditReportResult_CreditLimit
    {
        public string DEBTOR_ID { get; set; } = "";
        public string EXISTING_CREDIT_LIMIT { get; set; } = "";
        public string CREDIT_SCORE { get; set; } = "";
        public string CURRENT_DUE_PERCENTAGE { get; set; } = "";
        public string CALCULATED_CREDIT_LINE { get; set; } = "";
        public string CREDIT_CHECK { get; set; } = "";
        public string REPORT_ID { get; set; } = "";
    }
}
