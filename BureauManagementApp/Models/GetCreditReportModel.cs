using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class GetCreditReportModel
    {
        public string UserID { get; set; } = "";
        public string Password { get; set; } = "";
        public string AccountCode { get; set; } = "";
        public int Division { get; set; } 
        public Boolean IncludeScore { get; set; }
        public int AccountRequestId { get; set; }

        public string HTTP_GET_URL
        {
            get
            {
                return "https://ws.inetcreditexchange.com/ICEDirect.asmx/GetCreditReport?p_sUserID=" + UserID + "&p_sPassword=" + Password + "&p_sDivisionAccountNumber=" + AccountCode + "&p_iDivisionId=" + Division + "&p_bIncludeScore=" + IncludeScore + "&p_iAccountRequestId=" + AccountRequestId;
            }
        }
    }
}
