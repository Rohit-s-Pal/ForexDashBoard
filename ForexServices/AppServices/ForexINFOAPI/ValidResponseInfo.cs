using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using NET.Shared;



namespace ForexINFOAPI
{
    public class ValidResponseInfo
    {
        public string Status { set; get; }
        public string MSG { set; get; }
        public string MSGID { set; get; }

        public List<validmessage> lstvalidmessage { get; set; }
    }
    public class validmessage
    {
        public string validMSG { set; get; }
    }
}
