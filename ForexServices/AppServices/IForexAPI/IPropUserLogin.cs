using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace IForexAPI
{
    public interface IPropUserLogin
    {
        LoginResponseInfo ValidPropUserLogin(LoginInputInfo InputInfo);
        LoginResponseInfo ValidPropUserReLogin(LoginInputInfo InputInfo);
    }
}
