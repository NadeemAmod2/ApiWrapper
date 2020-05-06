using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class RequestCompanyLookup
    {
        public CmsCRCompanyLookup cmsCRCompanyLookup { get; set; }
        public string XML
        {
            get
            {
                string ret = "<?xml version=\"1.0\"?>" +
                    "<NACMCms>" +
                    "  <Request>" +
                    $"   <CmsCRCompanyLookup ValidationKey=\"{cmsCRCompanyLookup.ValidationKey}\">";

                if (cmsCRCompanyLookup.CompanyName != null && cmsCRCompanyLookup.CompanyName != "")
                {
                    ret += $"  <CompanyName>{cmsCRCompanyLookup.CompanyName}</CompanyName>";
                }
                if (cmsCRCompanyLookup.AddressLine1 != null && cmsCRCompanyLookup.AddressLine1 != "")
                {
                    ret += $"  <AddressLine1>{cmsCRCompanyLookup.AddressLine1}</AddressLine1>";
                }
                if (cmsCRCompanyLookup.AddressLine2 != null && cmsCRCompanyLookup.AddressLine2 != "")
                {
                    ret += $"  <AddressLine2>{cmsCRCompanyLookup.AddressLine2}</AddressLine2>";
                }
                if (cmsCRCompanyLookup.City != null && cmsCRCompanyLookup.City != "")
                {
                    ret += $"  <City>{cmsCRCompanyLookup.City}</City>";
                }
                if (cmsCRCompanyLookup.State != null && cmsCRCompanyLookup.State != "")
                {
                    ret += $"  <State>{cmsCRCompanyLookup.State}</State>";
                }
                if (cmsCRCompanyLookup.Country != null && cmsCRCompanyLookup.Country != "")
                {
                    ret += $"  <Country>{cmsCRCompanyLookup.Country}</Country>";
                }
                if (cmsCRCompanyLookup.Telephone != null && cmsCRCompanyLookup.Telephone != "")
                {
                    ret += $"  <Telephone>{cmsCRCompanyLookup.Telephone}</Telephone>";
                }

                ret += "   </CmsCRCompanyLookup>" +
                    "  </Request>" +
                    "</NACMCms>";

                return ret;
            }
        }

        public RequestCompanyLookup() { }
        public RequestCompanyLookup(CmsCRCompanyLookup cmsCRCompanyLookup)
        {
            this.cmsCRCompanyLookup = cmsCRCompanyLookup;
        }
    }
}
