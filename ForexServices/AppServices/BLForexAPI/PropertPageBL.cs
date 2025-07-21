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
