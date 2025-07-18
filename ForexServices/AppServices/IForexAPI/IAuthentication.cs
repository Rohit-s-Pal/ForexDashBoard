using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSSInfoAPI;

namespace INSSApi
{
   
    public interface IAuthentication
    {
        AuthenticationResponseInfo Authenticate(AuthenticationInputInfo InputInfo);
        AuthenticationResponseInfo_Registration Authentication_Registration(AuthenticationInputInfo_Registration InputInfo);
        

    }
}
