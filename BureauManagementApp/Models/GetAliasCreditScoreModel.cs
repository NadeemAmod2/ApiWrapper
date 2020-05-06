using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class GetAliasCreditScoreModel
    {
        public string UserID { get; set; } = "";
        public string Password { get; set; } = "";
        public string AccountCode { get; set; } = "";
        public int Division { get; set; }
        public int Days{ get; set; }
        public int PDBucket{ get; set; } = 30;

        public string HTTP_GET_URL
        {
            get
            {
                return "https://ws.inetcreditexchange.com/ICEDirect.asmx/GetAliasCreditScore?p_sUserID=" + UserID + "&p_sPassword=" + Password + "&p_sDivisionAccountNumber=" + AccountCode + "&p_iDivisionId=" + Division + "&p_iDays=" + Days + "&p_sBucket=" + PDBucket;
            }
        }
    }
}
