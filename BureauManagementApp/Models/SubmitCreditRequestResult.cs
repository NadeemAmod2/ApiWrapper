using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace BureauManagement.Models
{
    public class SubmitCreditRequestResult
    {
        public string ACCOUNT_REQUEST_ID { get; set; } = "";
        public string CREATE_DATE { get; set; } = "";
        public string ACCOUNT_NAME { get; set; } = "";
        public string BUS_ADDR1 { get; set; } = "";
        public string BUS_ADDR2 { get; set; } = "";
        public string BUS_CITY { get; set; } = "";
        public string BUS_STATE { get; set; } = "";
        public string BUS_ZIPCODE { get; set; } = "";
        public string BUS_PHONE1 { get; set; } = "";
        public string DUPLICATE { get; set; } = "";
        public string ADDRESS_CLEANSED { get; set; } = "";
        public string APPLICANT_ALIASED { get; set; } = "";
        public string CREDIT_CHECK { get; set; } = "";
        public string CREDIT_SCORE { get; set; } = "";
        public string CURRENT_DUE_PCT { get; set; } = "";
        public string CREDIT_LINE { get; set; } = "";
        public string CREDIT_REPORT { get; set; } = "";
        public string DIVISION_ACCOUNT_NUMBER { get; set; } = "";
        public string COMPLETED { get; set; } = "";
        public string FORM_ID { get; set; } = "";
        public string COLLECTION_DATE { get; set; } = "";
        public string HISTORICAL_SCORE { get; set; } = "";
        public string PD91_AMT { get; set; } = "";

        public SubmitCreditRequestResult() { }
        public SubmitCreditRequestResult(string XML)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XML);
            XmlNode node = doc.SelectSingleNode(".//NewDataSet/Table/ACCOUNT_REQUEST_ID");
            if (node != null)
            {
                ACCOUNT_REQUEST_ID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CREATE_DATE");
            if (node != null)
            {
                CREATE_DATE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/ACCOUNT_NAME");
            if (node != null)
            {
                ACCOUNT_NAME = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_ADDR1");
            if (node != null)
            {
                BUS_ADDR1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_ADDR2");
            if (node != null)
            {
                BUS_ADDR2 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_CITY");
            if (node != null)
            {
                BUS_CITY = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_STATE");
            if (node != null)
            {
                BUS_STATE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_ZIPCODE");
            if (node != null)
            {
                BUS_ZIPCODE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/BUS_PHONE1");
            if (node != null)
            {
                BUS_PHONE1 = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/DUPLICATE");
            if (node != null)
            {
                DUPLICATE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/ADDRESS_CLEANSED");
            if (node != null)
            {
                ADDRESS_CLEANSED = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/APPLICANT_ALIASED");
            if (node != null)
            {
                APPLICANT_ALIASED = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CREDIT_CHECK");
            if (node != null)
            {
                CREDIT_CHECK = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CREDIT_SCORE");
            if (node != null)
            {
                CREDIT_SCORE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CURRENT_DUE_PCT");
            if (node != null)
            {
                CURRENT_DUE_PCT = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CREDIT_LINE");
            if (node != null)
            {
                CREDIT_LINE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/CREDIT_REPORT");
            if (node != null)
            {
                CREDIT_REPORT = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/DIVISION_ACCOUNT_NUMBER");
            if (node != null)
            {
                DIVISION_ACCOUNT_NUMBER = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/COMPLETED");
            if (node != null)
            {
                COMPLETED = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/FORM_ID");
            if (node != null)
            {
                FORM_ID = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/COLLECTION_DATE");
            if (node != null)
            {
                COLLECTION_DATE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/HISTORICAL_SCORE");
            if (node != null)
            {
                HISTORICAL_SCORE = node.InnerText.Trim();
            }
            node = doc.SelectSingleNode(".//NewDataSet/Table/PD91_AMT");
            if (node != null)
            {
                PD91_AMT = node.InnerText.Trim();
            }
        }
    }
}
