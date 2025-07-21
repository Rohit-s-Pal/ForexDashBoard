using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace ForexAPI
{

    public class APIResponseBody : IDisposable
    {
        public string type { get; set; }
        public string message { get; set; }

        //public object message { get; set; }

        public int code { get; set; }
        public int subcode { get; set; }
        
        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }

    public class APIClientResponseBody : IDisposable
    {
        public string Message { get; set; }
        public void Dispose() { }
    }
    //mandars

    public class WMAMCApiClient : IDisposable
    {
        public string requestUriString { get; set; }
        
        public string postDataString { get; set; }
        public string contentType { get; set; }
        public System.Collections.Specialized.NameValueCollection headerNameValueCollection { get; set; }

        public APIResponseBody Get()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.Method = "GET";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            request.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            if (headerNameValueCollection != null && headerNameValueCollection.Count > 0)
                request.Headers.Add(headerNameValueCollection);
            var responseResult = new APIResponseBody();

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            responseResult = CommonUtility.Deserialize<APIResponseBody>(response);
                        }
                    }
                }
            }
            catch (System.Net.WebException e)
            {
                using (Stream webStream = e.Response.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            responseResult = CommonUtility.Deserialize<APIResponseBody>(response);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return responseResult;
        }

        public APIResponseBody Post()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.Method = "POST";
            request.ContentType = contentType;//contentType;// "application/x-www-form-urlencoded";//"application/json";
            request.ContentLength = postDataString.Length;
            //request.Headers.Add("mandar", "mandar");
            //request.Headers.Add("postDataString", postDataString);
            //headerNameValueCollection = new System.Collections.Specialized.NameValueCollection();
            ////headerNameValueCollection.Add("postDataString", postDataString);
            //if (headerNameValueCollection != null && headerNameValueCollection.Count > 0)
            //    request.Headers.Add(headerNameValueCollection);
            var responseResult = new APIResponseBody();
            var errorResponseResult = new APIClientResponseBody();

            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(postDataString);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            responseResult = CommonUtility.Deserialize<APIResponseBody>(response);
                        }
                    }
                }
            }
            catch (System.Net.WebException e)
            {
                using (Stream webStream = e.Response.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            return CommonUtility.Deserialize<APIResponseBody>(response);
                        }
                    }
                }
                return CommonUtility.Deserialize<APIResponseBody>(errorResponseResult.Message);
            }
            catch (Exception e)
            {
                throw e;
            }
            return responseResult;
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}