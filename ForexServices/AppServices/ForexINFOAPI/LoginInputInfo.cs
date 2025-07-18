using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    public class LoginInputInfo : BaseInputInfo
    {
        public string? EmailID { get; set; }
        public string? MobiNumb { get; set; }
        public string? Password { get; set; }


        //Login Objects ForgotLogin
        public string? ForgotMail { get; set; }
        public long? ForgotMobile { get; set; } // Nullable
        public int? OTP { get; set; }           // Nullable

        public string? LoginForgotRecheckOtp { get; set; }
        //Login Objects Password Change
        public string? LoginNewPass { get; set; }
        public string? LoginConfirmPass { get; set; }


        //Company Login Objects.
        public string? CompanyId { get; set; }
        public string? CompanyEmail { get; set; }

        public string? CompanyPassword { get; set; }

        //Company Forgot Objects.
        public string? ForgotCompanyId { get; set; }
        public string? ForgotCompanyMail { get; set; }
        public string? ForgotCompanyMobile { get; set; }

        //Company ForgotOtp Objects.
        public string? CompanyForgotOtp { get; set; }
        //Company Passwordchange Objects.

        public string? CompanyNewPassword { get; set; }
        public string? CompanyConfirmPassword { get; set; }

    }

    
}
