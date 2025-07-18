using ForexINFOAPI;
//using NET.Shared;
using System.Data;

namespace IForexAPI
{
    public interface IActivity
    {
        DashboardActivityResponseInfo DashboardActivity(DashboardActivityInputInfo InputInfo);
        ActivityCallingResponseInfo ActivityCalling(ActivityCallingInputInfo InputInfo);

        CallingActivityResponseInfo CallingActivity(CallingActivityInputInfo InputInfo);

        CallingActivitySummaryResponseInfo CallingActivitySummary(CallingActivitySummaryInputInfo InputInfo);


        //ActivityResponseInfo ActivityWindow(ActivityInputInfo InputInfo);

    }
}
