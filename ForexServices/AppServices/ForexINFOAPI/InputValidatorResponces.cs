using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    public class InputValidatorResponces : BaseResponseInfo
    {
        public int IPVStatus { get; set; }
        public string IPVMSG { get; set; }
    }
}
