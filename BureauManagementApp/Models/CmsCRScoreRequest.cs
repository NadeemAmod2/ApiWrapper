using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class CmsCRScoreRequest
    {
        public string ValidationKey { get; set; } = "";
        public string CompanyNACMID { get; set; } = "";
        public string Type { get; set; } = "";
    }
}
