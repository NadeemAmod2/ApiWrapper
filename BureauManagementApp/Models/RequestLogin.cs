using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BureauManagement.Models
{
    public class RequestLogin
    {
        public CmsLogin cmsLogin { get; set; }
        public string XML
        {
            get
            {
                return "<?xml version=\"1.0\"?>" +
                    "<NACMCms>" +
                    "  <Request>" +
                    "   <CMSLogin>" +
                    "       <AccessCode>" + cmsLogin.AccessCode + "</AccessCode>" +
                    (cmsLogin.UserRef != null ? "       <UserRef>" + cmsLogin.AccessCode + "</UserRef>" : "") +
                    "   </CMSLogin>" +
                    "  </Request>" +
                    "</NACMCms>";
            }
        }

        public RequestLogin() { }
        public RequestLogin(CmsLogin cmslogin)
        {
            this.cmsLogin = cmslogin;
        }
    }
}
