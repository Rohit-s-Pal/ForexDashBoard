using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace IForexAPI
{
    public interface IPropertyPage
    {
       
        PropertyPageResponseInfo PropertyPageData(PropertyPageInputInfo inputInfo);
        
    }
}
