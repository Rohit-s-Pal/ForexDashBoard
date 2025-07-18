using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLPropertyApi;
using IPropertyAPI;
using PropertyINFOAPI;

namespace BLPropertyAPI
{
    public class PropertyPageBL : IPropertyPage
    {
        public PropertyPageBL() { }
        private IPropertyPage GetDALObject()
        {
            return DALFactory.GetPropertyPageDAL();
        }

        public PropertyPageResponseInfo PropertyPageData(PropertyPageInputInfo InputInfo)
        {
            IPropertyPage iPropertyPage = null;

            try
            {
                iPropertyPage = GetDALObject();
                return iPropertyPage.PropertyPageData(InputInfo);
            }
            catch
            {
                throw;
            }
            finally
            {
                iPropertyPage = null;
            }
        }
        

    }
}
