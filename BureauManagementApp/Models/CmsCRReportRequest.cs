using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class CmsCRReportRequest
    {
        public string ValidationKey { get; set; } = "";
        public string CompanyNACMID { get; set; } = "";
        public string ReturnHTML { get; set; } = "";
        public string Options { get; set; } = "";
    }
}
