using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class BureauRequest
    {
        public int RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestLogin { get; set; }
        public string RequestBody { get; set; }
        public string RequestValues { get; set; }
        public int BureauID { get; set; }
        public DateTime DateUpdated { get; set; }

        public string query
        {
            get
            {
                return $"INSERT INTO BureauRequest (RequestDate, RequestLogin, RequestBody, RequestValues, BureauID, DateUpdated) VALUES ('{RequestDate}', '{RequestLogin}', '{RequestBody}', '{RequestValues}', {BureauID}, '{DateUpdated}') SELECT CAST(SCOPE_IDENTITY() as int)";
            }
        }

        public BureauRequest()
        {
            RequestDate = DateTime.Now;
            RequestLogin = "";
            RequestBody = "";
            RequestValues = "";
        }
        public BureauRequest(DateTime reqDate, string reqLogin, string reqBody, string reqValues, int bureauId, DateTime dateUpdated)
        {
            RequestDate = reqDate;
            RequestLogin = reqLogin;
            RequestBody = reqBody;
            RequestValues = reqValues;
            BureauID = bureauId;
            DateUpdated = dateUpdated;
        }
    }
}
