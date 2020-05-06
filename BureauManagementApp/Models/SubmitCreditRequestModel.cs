using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class SubmitCreditRequestModel
    {
        public string UserID { get; set; } = "";
        public string Password { get; set; } = "";          
        public int CompanyId{ get; set; }
        public string AccountName { get; set; } = ""; 
        public string BusAddr1 { get; set; } = "";
        public string BusCity { get; set; } = ""; 
        public string BusState { get; set; } = "";
        public string BusZipCode { get; set; } = "";
        public string BusPhone { get; set; } = "";

        public string HTTP_GET_URL
        {
            get
            {
                return "https://ws.inetcreditexchange.com/ICEDirect.asmx/SubmitCreditRequest?p_sUserID=" + UserID + "&p_sPassword=" + Password + "&p_iCompanyId=" + CompanyId + "&p_sAccountName=" + AccountName + "&p_sBusAddr1=" + BusAddr1 + "&p_sBusCity=" + BusCity + "&p_sBusState=" + BusState + "&p_sBusZipCode=" + BusZipCode + "&p_sBusPhone=" + BusPhone;
            }
        }
    }
}
