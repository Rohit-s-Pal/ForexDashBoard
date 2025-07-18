using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    public class LoginResponseInfo : BaseResponseInfo
    {
        public string Token { set; get; }
        public string RefreshToken { set; get; }

       
        public List<MenuList> menulist { get; set; }
        public List<ContAction> contaction { get; set; }
        public List<LoginUser> loginUser { get; set; }
        public List<ForgotUserLogin> forgotUserLogin { get; set; }



    }

    public class CompUserResponseInfo : BaseResponseInfo
    {

        public List<CompUser> loginUser { get; set; }
        public List<ForgotUserLogin> forgotUserLogin { get; set; }
        public List<Menu> lstMenu { get; set; }


    }

    public class MenuList
    {
        public string MenuID { get; set; }
        public string MenuName { get; set; }
        public string IsChildren   { get; set; }
        public string ParentID  { get; set; }
        public string Seq  { get; set; }
        public string PageURL  { get; set; }
        
    }

    public class ContAction
    {
        public string ContActionID { get; set; }
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public bool IsAllowed { get; set; }
    }
    public class LoginUser
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string DashboardURL { get; set; }

        public string OTPSMS { get; set; }

        public string UserMobi { get; set; }
        public string OTPType { get; set; }
        public string FName { get; set; }
        public string LastName { get; set; }        
        public string emailID { get; set; }
        public string JobfileRegiID { get; set; }
        public string LastLoginDate { get; set; }
        public string LastCompanyName { get; set; }
        public string City { get; set; }
        public string LastProfileModiDate { get; set; }

        public string ResumeName { get; set; }
        public string ResumePath { get; set; }
        public string ResumeLastUpdate { get; set; }
        public string Profilepic { get; set; }
        public string OTPStatus { get; set; }

    }

    public class CompUser   /* Company User Information */
    {
        public string UserID { get; set; }
        public string FullName { get; set; }

        public string OTPSMS { get; set; }

        public string Mobinumb { get; set; }
        public string OTPType { get; set; }
        public string FName { get; set; }
        public string LastName { get; set; }
        public string emailID { get; set; }
        public string fileRegiID { get; set; }
        public string LastLoginDate { get; set; }
        public string LastCompanyName { get; set; }
        public string City { get; set; }
        public string LastProfileModiDate { get; set; }

        public string ResumeName { get; set; }
        public string ResumePath { get; set; }
        public string ResumeLastUpdate { get; set; }
        public string Profilepic { get; set; }
        public string CompName { get; set; }
        public string CompID { get; set; }
        public string SubsExpiDate { get; set; }

        public string IsAdmin { get; set; }
        public string RoleID { get; set; }

    }

    public class Menu
    {
        public string ControllerView { get; set; }
        public string Type { get; set; } 
    }

    public class ForgotUserLogin
    {
        public string  OTPSMS { get; set; }
        public string Mobinumb { get; set; }
        public string UserID { get; set; }


    }
    
}
