using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IForexAPI;
using ForexINFOAPI;
using System.Data;
using NET.Shared;


namespace BLForexApi
{
    public class ActivityBL : IActivity
    {
        public ActivityBL()
        {

        }

        public ActivityCallingResponseInfo ActivityCalling(ActivityCallingInputInfo InputInfo)
        {
            throw new NotImplementedException();
        }

        public CallingActivityResponseInfo CallingActivity(CallingActivityInputInfo InputInfo)
        {
            throw new NotImplementedException();
        }

        public CallingActivitySummaryResponseInfo CallingActivitySummary(CallingActivitySummaryInputInfo InputInfo)
        {
            throw new NotImplementedException();
        }

        public DashboardActivityResponseInfo DashboardActivity(DashboardActivityInputInfo InputInfo)
        {
            throw new NotImplementedException();
        }
    }
}
