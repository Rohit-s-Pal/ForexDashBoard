using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NET.Shared;
namespace ForexINFOAPI
{
    class ActivityInfo
    {
    }


    public class DashboardActivityInputInfo : BaseInputInfo
    {

        public string PartId { get; set; }

        public string SearchValue { get; set; }



    }

    public class DashboardActivityResponseInfo : BaseResponseInfo
    {
        public List<Activity> lstTodaysActivity { get; set; }
        public List<Activity> lstMissedActivity { get; set; }

        public List<Activity> lstNextDayActivity { get; set; }

        public List<CallingActivity> lstCallingTodaysActivity { get; set; }
        public List<CallingActivity> lstCallingTodaysList { get; set; }

        public List<CallingActivity> lstCallingIntrestedList { get; set; }

    }

    public class ActivityCallingResponseInfo : BaseResponseInfo
    {
        public CallingActivity CallingDeta { get; set; }
        
        public List<ActivityLog> lstActivityLog { get; set; }

       

        public List<SMSTemplate> lstSMSTemplate { get; set; }

        public string NextFollowDate { get; set; }
        public string InterviewDate { get; set; }
        public string Remark { get; set; }

        public string ActivityStatusID { get; set; }
        public string SMSTemplateLisID { get; set; }

        public string SMSText { get; set; }
        public string ProcType { get; set; }
        public string JobRegiID { get; set; }
        public string JobPostID { get; set; }


    }

    public class ActivityCallingInputInfo : BaseInputInfo
    {
        public string CallingActivityDetaId { get; set; }
        public string JobRegiID { get; set; }
        public string JobPostID { get; set; }

    }



    public class Activity
    {
        public string ActivityMastID { get; set; }      /* Unique ID */
        public string CompanyName { get; set; }                /* Company Name */
        public string HRName { get; set; }                /* Customer Name */
        public string Date { get; set; }                /* Customer Name */
        public string HRNumber { get; set; }                /* Customer Name */
        public string Caller { get; set; }              /* Caller Name */
        public string Remark { get; set; }              /* Communication LOG */
        public string ActiDesc { get; set; }            /* Activity Type ? what kind of Activity  */
        public string ActivityID { get; set; }          /* Activity Type  ID */
        public string CompanyID { get; set; }              /* Customer ID for opening profile */
        public string HRID { get; set; }              /* Customer ID for opening profile */


    }

    public class ActivityInputInfo : BaseInputInfo
    {
        public string CustID { get; set; }
        public string ActivityMastID { get; set; }
        public string ActivityID { get; set; }


        //public eCRCommLogSaveInputInfo commLog { get; set; }

    }

    public class CallingActivity
    {
        public string CallingActivitymastID { get; set; }

        public string HRName { get; set; }
        public string DateofCall { get; set; }
        public string Title { get; set; }
        public string CandidateName { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string Mobile { get; set; }
        public string EmailID { get; set; }
        public string Location { get; set; }
        public string Experiences { get; set; }
        public string Monthly { get; set; }
        public string CTC { get; set; }
        public string ExpCTC { get; set; }
        public string NoticePeriod { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string NextFollowUpDate { get; set; }
        public string JobByRole { get; set; }
        public string CompanyName { get; set; }
        public string MinAddress { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }


    }

    public class ActivityLog
    {
        public string Caller { get; set; }

        public string CallDate { get; set; }
        public string Remark { get; set; }
        public string FollowUpDate { get; set; }
        public string Status { get; set; }
    }

    public class SMSTemplate
    {
        public string TemplateDesc { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class CallingActivityInputInfo : BaseInputInfo
    {
        public string ActivityMastID { get; set; }
        public string Remark { get; set; }
        public string StatusID { get; set; }
        public string SMSTemplateID { get; set; }
        public string SMSTemplate { get; set; }
        public string FollowupDate { get; set; }
        public string InterviewDate { get; set; } 
        public string JobRegiID { get; set; }
        public string JobPostID { get; set; }

    }

    public class CallingActivityResponseInfo : BaseResponseInfo
    {

    }

    public class CallingActivitySummaryInputInfo : BaseInputInfo
    {
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ReportType { get; set; }
    }

    public class CallingActivitySummaryResponseInfo : BaseResponseInfo
    {
       

    }
}
