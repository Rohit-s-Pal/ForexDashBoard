using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLForexApi;
using IForexAPI;
using ForexINFOAPI;

namespace BLForexApi
{
    public class PropUserBL : IPropUserLogin
    {
        public PropUserBL() { }

        private IPropUserLogin GetDALObject()
        {
            return DALFactory.GetPropUserDAL();
        }



        public LoginResponseInfo ValidPropUserLogin(LoginInputInfo InputInfo)
        {
            IPropUserLogin iPropUserLogin = null;

            try
            {
                iPropUserLogin = GetDALObject();
                return iPropUserLogin.ValidPropUserLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iPropUserLogin = null;
            }
        }
        public LoginResponseInfo ValidPropUserReLogin(LoginInputInfo InputInfo)
        {
            IPropUserLogin iPropUserLogin = null;

            try
            {
                iPropUserLogin = GetDALObject();
                return iPropUserLogin.ValidPropUserReLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iPropUserLogin = null;
            }
        }
    }
}
