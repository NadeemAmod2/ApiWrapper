using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BureauManagement.Models;
using Microsoft.Extensions.Configuration;


namespace BureauManagement.Controllers
{
    [ApiController]
    [Route("bureaumgr-api/v1/ice")]
    public class ICEController: ControllerBase
    {
        [HttpPost("GetAliasCreditScore")]
        public ActionResult<GetAliasCreditScoreResult> GetAliasCreditScore([FromBody] GetAliasCreditScoreModel data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToICE(data.HTTP_GET_URL);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            GetAliasCreditScoreResult ret = new GetAliasCreditScoreResult(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }
        
        [HttpPost("GetCreditReport")]
        public ActionResult<GetCreditReportResult> GetCreditReport([FromBody] GetCreditReportModel data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToICE(data.HTTP_GET_URL);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            GetCreditReportResult ret = new GetCreditReportResult(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }
        
        [HttpPost("SubmitCreditRequest")]
        public ActionResult<SubmitCreditRequestResult> SubmitCreditRequest([FromBody] SubmitCreditRequestModel data)
        {
            if (data == null) return BadRequest();

            int reqId = Utils.DatabaseAdapter.saveBureauRequest(data);
            if (reqId == 0)
            {
                return Ok("Data not saved in DB");
            }
            string xmlRet = Utils.Caller.sendRequestToICE(data.HTTP_GET_URL);
            if (xmlRet == null)
            {
                return Ok("Got empty response string from the service");
            }
            SubmitCreditRequestResult ret = new SubmitCreditRequestResult(xmlRet);
            Utils.DatabaseAdapter.saveBureauResponse(ret, reqId);

            return Ok(ret);
        }
    }
}