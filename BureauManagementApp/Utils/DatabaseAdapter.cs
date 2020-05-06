using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BureauManagement.Models;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BureauManagement.Utils
{
    public class DatabaseAdapter
    {
        public static int BUREAU_ID_TransUnion = 3;
        public static int BUREAU_ID_NACM_SE = 4;
        public static int BUREAU_ID_NACM_National = 5;
        public static int BUREAU_ID_ICE = 6;
        public static int BUREAU_ID_DnB = 7;
        public static int RES_LOGIN_ID_VALID = 1;
        public static int RES_LOGIN_ID_INVALID = 2;
        public static int RES_LOGIN_ID_NORESPONSE = 3;

        private static IConfiguration configuration;

        public static void setConfiguration(IConfiguration conf)
        {
            configuration = conf;
        }

        private static int saveData(string query)
        {
            int ret = 0;

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                var dbConnectionSettings = configuration.GetSection("DatabaseConnectionSettings");
                builder.DataSource = dbConnectionSettings["DataSource"];
                builder.UserID = dbConnectionSettings["UserID"];
                builder.Password = dbConnectionSettings["Password"];
                builder.InitialCatalog = dbConnectionSettings["InitialCatalog"];
                
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ret = reader.GetInt32(0);
                                //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return ret;
        }

        public static int saveBureauRequest(BureauRequest req)
        {
            return saveData(req.query);
        }
        public static int saveBureauResponse(BureauResponse res)
        {
            return saveData(res.query);
        }


        public static int saveBureauRequest(GetAliasCreditScoreModel req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"({req.UserID}, {req.Password})", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BUREAU_ID_ICE, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(GetCreditReportModel req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"({req.UserID}, {req.Password})", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BUREAU_ID_ICE, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(SubmitCreditRequestModel req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"({req.UserID}, {req.Password})", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BUREAU_ID_ICE, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(int BureauId, CmsLogin req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"{req.AccessCode}", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BureauId, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(int BureauId, CmsCRCompanyLookup req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"{req.ValidationKey}", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BureauId, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(int BureauId, CmsCRReportRequest req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"{req.ValidationKey}", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BureauId, curDateTime);
            return saveBureauRequest(reqObj);
        }
        public static int saveBureauRequest(int BureauId, CmsCRScoreRequest req)
        {
            DateTime curDateTime = DateTime.Now;
            BureauRequest reqObj = new BureauRequest(curDateTime, $"{req.ValidationKey}", Newtonsoft.Json.JsonConvert.SerializeObject(req), "", BureauId, curDateTime);
            return saveBureauRequest(reqObj);
        }

        public static int saveBureauResponse(GetAliasCreditScoreResult res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(GetCreditReportResult res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(SubmitCreditRequestResult res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(CmsValidation res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(CmsCRCompanyList res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(CmsCRReportDetail res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
        public static int saveBureauResponse(CmsCRScoreDetail res, int reqId)
        {
            BureauResponse resObj = new BureauResponse(reqId, RES_LOGIN_ID_VALID, Newtonsoft.Json.JsonConvert.SerializeObject(res), "", DateTime.Now);
            return saveBureauResponse(resObj);
        }
    }
}
