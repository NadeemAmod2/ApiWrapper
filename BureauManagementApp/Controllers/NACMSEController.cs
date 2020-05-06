using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BureauManagement.Models;


namespace BureauManagement.Controllers
{
    [ApiController]
    [Route("bureaumgr-api/v1/nacmse")]
    public class NACMSECaller: ControllerBase
    {
        [HttpPost("login")]
        public ActionResult<CmsValidation> Login([FromBody] CmsLogin data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(Utils.DatabaseAdapter.BUREAU_ID_NACM_SE, data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToNACM(Utils.Caller.API_URL_NACMSE, new RequestLogin(data).XML);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            CmsValidation ret = new CmsValidation(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }

        [HttpPost("company-lookup")]
        public ActionResult<CmsCRCompanyList> CompanyLookup([FromBody] CmsCRCompanyLookup data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(Utils.DatabaseAdapter.BUREAU_ID_NACM_SE, data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToNACM(Utils.Caller.API_URL_NACMSE, new RequestCompanyLookup(data).XML);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            CmsCRCompanyList ret = new CmsCRCompanyList(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }

        [HttpPost("report-detail")]
        public ActionResult<CmsCRReportDetail> ReportDetail([FromBody] CmsCRReportRequest data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(Utils.DatabaseAdapter.BUREAU_ID_NACM_SE, data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToNACM(Utils.Caller.API_URL_NACMSE, new RequestReport(data).XML);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            CmsCRReportDetail ret = new CmsCRReportDetail(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }

        [HttpPost("score-detail")]
        public ActionResult<CmsCRScoreDetail> ScoreDetail([FromBody] CmsCRScoreRequest data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(Utils.DatabaseAdapter.BUREAU_ID_NACM_SE, data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToNACM(Utils.Caller.API_URL_NACMSE, new RequestScore(data).XML);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            CmsCRScoreDetail ret = new CmsCRScoreDetail(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }
    }
}
