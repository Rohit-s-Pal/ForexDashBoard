using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IPropertyAPI;

using PropertyINFOAPI;

namespace BLPropertyApi
{
    public class RecruiterBL : IRecruiter
    {

        public RecruiterBL()
        {

        }

        private IRecruiter GetDALObject()
        {
            return DALFactory.GetRecruiterDAL();
        }
        
        

        public LoginResponseInfo ValidRecruiterLogin(LoginInputInfo InputInfo)
        {
            IRecruiter iRecruiter = null;

            try
            {
                iRecruiter = GetDALObject();
                return iRecruiter.ValidRecruiterLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iRecruiter = null;
            }
        }
        public LoginResponseInfo ValidRecruiterReLogin(LoginInputInfo InputInfo)
        {
            IRecruiter iRecruiter = null;

            try
            {
                iRecruiter = GetDALObject();
                return iRecruiter.ValidRecruiterReLogin(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iRecruiter = null;
            }
        }

        



    }
}
