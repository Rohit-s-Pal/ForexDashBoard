using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ForexINFOAPI;
using IForexAPI;

namespace BLForexApi
{
    public class CMSUserBL : ICMSUser
    {
        public CMSUserBL() { }

        private ICMSUser GetDALObject()
        {
            return DALFactory.GetCMSUserDAL();
        }

        public LoginResponseInfo ValidUserLogin(LoginInputInfo InputInfo)
        {
            ICMSUser iCMSUser = null;

            try
            {
                iCMSUser = GetDALObject();
                return iCMSUser.ValidUserLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iCMSUser = null;
            }
        }
        public LoginResponseInfo ValidUserReLogin(LoginInputInfo InputInfo)
        {
            ICMSUser iCMSUser = null;

            try
            {
                iCMSUser = GetDALObject();
                return iCMSUser.ValidUserReLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iCMSUser = null;
            }
        }
    }
}
