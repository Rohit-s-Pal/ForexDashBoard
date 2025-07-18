using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    public class BaseResponseInfo : BaseInfo
    {
        public BaseResponseInfo()
        {
        }

        public BaseResponseInfo(string status, string errorCode, string errorDescription)
        {
            Status = status;
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }
        public string ErrorCode { set; get; }


        public string ErrorDescription { set; get; }

       
        public string Status { set; get; }


        public string MSG { set; get; }

        public string MSGID { set; get; }
        public string AuthKey { set; get; }

        public string BrowserURL { get; set; }

        public ValidResponseInfo validResponseInfo { get; set; }

    }
}
