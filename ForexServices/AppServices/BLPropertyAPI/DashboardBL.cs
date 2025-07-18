using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IPropertyAPI;
using PropertyINFOAPI;

namespace BLPropertyApi
{
    public class DashboardBL : IDashboard
    {
        public DashboardBL()
        {

        }

        private IDashboard GetDALObject()
        {
            return DALFactory.GetDashboardDAL();
        }

        public DashboardRecruiterResponseInfo DashboardRecruiter(DashboardRecruiterInputInfo InputInfo)
        {
            IDashboard iDashboard = null;

            try
            {
                iDashboard = GetDALObject();
                return iDashboard.DashboardRecruiter(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iDashboard = null;
            }
        }
    }
}
