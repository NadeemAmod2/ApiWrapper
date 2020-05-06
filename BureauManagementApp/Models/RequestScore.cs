using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class RequestScore
    {
        public CmsCRScoreRequest cmsCRScoreRequest { get; set; }
        public string XML
        {
            get
            {
                return "<?xml version=\"1.0\"?>" +
                    "<NACMCms>" +
                    "  <Request>" +
                    $"   <CmsCRScoreRequest ValidationKey=\"{cmsCRScoreRequest.ValidationKey}\">" +
                    $"       <CompanyNACMID>{cmsCRScoreRequest.CompanyNACMID}</CompanyNACMID>" +
                    $"       <Type>{cmsCRScoreRequest.Type}</Type>" +
                    "   </CmsCRScoreRequest>" +
                    "  </Request>" +
                    "</NACMCms>";
            }
        }

        public RequestScore() { }
        public RequestScore(CmsCRScoreRequest cmsCRScoreRequest)
        {
            this.cmsCRScoreRequest = cmsCRScoreRequest;
        }
    }
}
