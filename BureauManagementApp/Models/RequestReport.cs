using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class RequestReport
    {
        public CmsCRReportRequest cmsCRReportRequest { get; set; }
        public string XML
        {
            get
            {
                return "<?xml version=\"1.0\"?>" +
                    "<NACMCms>" +
                    "  <Request>" +
                    $"   <CmsCRReportRequest ValidationKey=\"{cmsCRReportRequest.ValidationKey}\">" +
                    $"       <CompanyNACMID>{cmsCRReportRequest.CompanyNACMID}</CompanyNACMID>" +
                    $"       <ReturnHTML>{cmsCRReportRequest.ReturnHTML}</ReturnHTML>" +
                    $"       <Options>{cmsCRReportRequest.Options}</Options>" + 
                    "   </CmsCRReportRequest>" +
                    "  </Request>" +
                    "</NACMCms>";
            }
        }

        public RequestReport() { }
        public RequestReport(CmsCRReportRequest cmsCRReportRequest)
        {
            this.cmsCRReportRequest = cmsCRReportRequest;
        }
    }
}
