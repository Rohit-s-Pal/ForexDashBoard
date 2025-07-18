using System.Linq;
using IForexAPI;
using ForexINFOAPI;
using System.Data;
using Shared.DataAccess;
using Dapper;
//using NET.Shared;

using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DALForexAPI
{
    public class ActivityDAL : IActivity
    {
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
