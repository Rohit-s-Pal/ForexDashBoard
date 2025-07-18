using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForexINFOAPI
{
    class DashboardRecruiter
    {

    }

  
    public class DashboardRecruiterInputInfo : BaseInputInfo
    {
        public List<ComboDeta> lstRecruiter { get; set; } = new();
        public DateRange? DateRange { get; set; } = new();
        public string? RecruiterID { get; set; } = "0";


    }

    public class DashboardRecruiterResponseInfo : BaseResponseInfo
    {
        public List<DashboardStatistics> lstDashboardStatistics { get; set; }
        public List<DashboardJobPosting> lstDashboardJobPosting { get; set; }
        public List<DashboardGraph> lstDashboardGraph { get; set; }
        public List<DashboardCallLog> lstDashboardCallLog { get; set; }
        public List<DashboardActivity> lstDashboardActivity { get; set; }
        public List<ComboDeta> lstRecruiter { get; set; }
        public DateRange DateRange { get; set; }
        public string? RecruiterID {  get; set; }

    }


    public class DashboardStatistics
    {
        public string? StatID { get; set; }
        public string? StatTitle { get; set; }
        public string? StatUnits { get; set; }
        public string? Tooltip { get; set; }
        public string? StatUrl { get; set; }
        public string? ColorCode { get; set; }
        
        public string? Seq { get; set; }
    }
    public class DashboardStatistics1
    {

        public string? NumberOfCalls { get; set; }
        public string? OpenCalls { get; set; }
        public string? ResponseAwaited { get; set; }
        public string? Selected { get; set; }
        public string? RevenueGenerated { get; set; }
        public string? NewRegistration { get; set; }
        public string? CandidateInterview { get; set; }
        public string? IncompleteProfile { get; set; }

        public string? WhatsappMessage { get; set; }
        public string? FollowupCall { get; set; }
        public string? UpcomingLWD { get; set; }

        public string? UDV1 { get; set; }
        public string? UDV2 { get; set; }
        public string? UDV3 { get; set; }
        public string? UDV4 { get; set; }
        public string? UDV5 { get; set; }

    }

    public class DashboardJobPosting
    {

        public string JobPostID { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public int TotalViews { get; set; }
        public int Matches { get; set; }
        public int Applied { get; set; }


    }
    public class DashboardGraph
    {
        public string? CallTime { get; set; }
        public string? NumberofCalls { get; set; }
        //public string? DateTime { get; set; }
    }

    public class DashboardCallLog
    {
        public string? CallTime { get; set; }
        public string? Name { get; set; }
        public string? Remark { get; set; }
        public string? Status { get; set; }
        public string? JobRegiID { get; set; }
    }

    public class DashboardActivity
    {
        public string? ActivityID { get; set; }
        public string? Activity { get; set; }
        public string? Status { get; set; }
    }
}
