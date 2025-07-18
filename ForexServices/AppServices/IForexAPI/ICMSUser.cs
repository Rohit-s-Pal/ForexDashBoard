using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace IForexAPI
{
    public interface ICMSUser
    {
        LoginResponseInfo ValidUserLogin(LoginInputInfo InputInfo);
        LoginResponseInfo ValidUserReLogin(LoginInputInfo InputInfo);
    }
}