using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace ForexINFOAPI
{
    class CMSDashboard
    {
    }

    public class CMSDashboardInputInfo : BaseInputInfo
    {
        public List<ComboDeta> lstCallingType { get; set; } = new();
        public string? DateTime { get; set; }
        public string? CallerID { get; set; }
       
    }
    public class CMSDashboardResponseInfo : BaseResponseInfo
    {
        public List<CMSDashboardStatistics> lstCMSDashboardStatistics { get; set; }
        public List<CMSDashboardCallingData> lstCMSDashboardCallingData { get; set; }
        public List<CMSCallingActivity> lstCMSCallingActivity { get; set; }
        public string? DateTime { get; set; }
    }

    public class CMSDashboardStatistics
    {
        public string? StatID { get; set; }
        public string? StatTitle { get; set; }
        public string? StatUnits { get; set; }
        public string? Tooltip { get; set; }
        public string? StatUrl { get; set; }
        public string? ColorCode { get; set; }

        public string? Seq { get; set; }
    }

    public class CMSDashboardCallingData
    {
        public string? CallingDataID { get; set; }
        public string? UserID { get; set; }
        public string? Name { get; set; }
        public string? DataTypeID { get; set; }
        public string? CreaOn { get; set; }
        public string? IsActive { get; set; }
    }

    public class CMSCallingActivity
    {
        public string? CallingActivityID { get; set; }
        public string? CallingTypeID { get; set; }
        public string? UserID { get; set; }
        public string? Name { get; set; }
        public string? MobiNumb { get; set; }
        public string? Remark { get; set; }
        public string? StatusId { get; set; }
        public string? StatusComboID { get; set; }
        public string? IsCallPending { get; set; }
        public string? FollowUp { get; set; }
        public string? CallDate { get; set; }
        public string? CreaOn { get; set; }
    }

    
}
