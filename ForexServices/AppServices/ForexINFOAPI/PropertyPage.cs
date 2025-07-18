using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ForexINFOAPI;

namespace ForexINFOAPI
{
    class PropertyPage
    {
    }

    public class PropertyPageInputInfo : BaseInputInfo
    {
        
        public string? Mode { get; set; }
        public string? City { get; set; }
        public string? location { get; set; }
        public string? bhk { get; set; }
        public string? Token { get; set; }
    
        

    }

    public class PropertyPageResponseInfo : BaseResponseInfo
    {

        public List<PropertyDetails> lstPropertyDetails { get; set; }

    }

    public class PropertyDetails
    {
        public string PropertyID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string BHK { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
    }

}
