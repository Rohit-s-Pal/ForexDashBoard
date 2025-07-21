using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace IForexAPI
{
    public interface IForexLogin
    {
        LoginResponseInfo ValidUserLogin(LoginInputInfo InputInfo);
    }

}
