using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLForexApi;
using ForexINFOAPI;
using IForexAPI;

namespace BLForexAPI
{
    public class ForexLoginBL : IForexLogin
    {
        public ForexLoginBL()
        {

        }

        private IForexLogin GetDALObject()
        {
            return DALFactory.GetForexUserDAL();
        }


        public LoginResponseInfo ValidUserLogin(LoginInputInfo InputInfo)
        {
            IForexLogin iForexLogin = null;

            try
            {
                iForexLogin = GetDALObject();
                return iForexLogin.ValidUserLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iForexLogin = null;
            }
        }
    }
}
