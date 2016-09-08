using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AzureAD
{
    public class AzureADUtility
    {
        public string Tenant { get; set; }
        public string ClientId { get; set; }
        public string Secret { get; set; }
        HttpStatusCode code;

        public AzureADUtility(string strTenant, string strClientId, string strSecret)
        {
            this.Tenant = strTenant;
            this.ClientId = strClientId;
            this.Secret = strSecret;
        }

        public Models.User.Result GetUsers()
        {
            string strUrl = "https://graph.windows.net/" + this.Tenant + "/users?api-version=1.6";
            Models.User.Result objResults = JsonConvert.DeserializeObject<Models.User.Result>(this.CallGraphAPI(strUrl, "GET", "", out code));
            return objResults;
        }

        public Models.User.Manager GetManager(string strObjectId)
        {
            string strUrl = $"https://graph.windows.net/{this.Tenant}/users/{strObjectId}/$links/manager?api-version=1.6";
            string strContent = this.CallGraphAPI(strUrl, "GET", "", out code);
            Models.User.Manager objMng = null;
            if (code == HttpStatusCode.OK)
                objMng = JsonConvert.DeserializeObject<Models.User.Manager>(strContent);
            return objMng;
        }

        protected string GetAuthorizationHeader()
        {
            AuthenticationResult result = null;
            var context = new AuthenticationContext("https://login.microsoftonline.com/" + this.Tenant);
            var thread = new Thread(() =>
            {
                result = context.AcquireToken("https://graph.windows.net", new ClientCredential(this.ClientId, this.Secret));
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Name = "AquireTokenThread";
            thread.Start();
            thread.Join();

            if (result == null)
            {
                throw new InvalidOperationException("Failed to obtain the JWT token");
            }

            return result.AccessToken;
        }

        protected string CallGraphAPI(string strUrl, string strHttpMethod, string strPostContent, out HttpStatusCode code)
        {
            string token = GetAuthorizationHeader();
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            request.Method = strHttpMethod;
            code = HttpStatusCode.OK;

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.KeepAlive = true;
                request.ContentType = "application/json";

                byte[] bs = Encoding.ASCII.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }
    }
}
