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

namespace BureauManagement.Utils
{
    public class Caller
    {
        public static string API_URL_NACM = "http://nacmcs.cicnetwork.com/util/cmsxml.asp";
        public static string API_URL_NACMSE = "http://nacm-se.cicnetwork.com/util/cmsxml.asp";

        public static string sendRequestToICE(string httpGetURL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(httpGetURL);
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }

            return null;
        }
        
        public static string sendRequestToNACM(string API_URL, string xmlData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API_URL);
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(xmlData);
            request.ContentType = "text/xml; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }

            return null;
        }
    }
}
