using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class BureauResponse
    {
        public int ResponseID { get; set; }
        public int RequestID { get; set; }
        public int ResponseLoginID { get; set; }
        public string Response { get; set; }
        public string ResponseValues { get; set; }
        public DateTime ResponseDate { get; set; }

        public string query
        {
            get
            {
                return $"INSERT INTO BureauResponse (RequestID, ResponseLoginID, Response, ResponseValues, ResponseDate) VALUES ({RequestID}, {ResponseLoginID}, '{Response}', '{ResponseValues}', '{ResponseDate}') SELECT CAST(SCOPE_IDENTITY() as int)";
            }
        }

        public BureauResponse()
        {
            Response = "";
            ResponseValues = "";
            ResponseDate = DateTime.Now;
        }
        public BureauResponse(int reqId, int resLoginId, string res, string resValues, DateTime resDate)
        {
            RequestID = reqId;
            ResponseLoginID = resLoginId;
            Response = res;
            ResponseValues = resValues;
            ResponseDate = resDate;
        }
    }
}
