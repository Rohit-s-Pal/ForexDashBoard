using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ForexINFOAPI
{
    class SignupRegistration
    {

    }
    public class SignupRegistrationInputInfo : BaseInputInfo
    {
        
        public string JobByRoleID { get; set; }
        public string JobTitle { get; set; }
        public string Pincode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string emaiID { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string IsResume { get; set; }
        public string IsTC { get; set; }
        public string MinExpYear { get; set; }
        public string MinExpMonth { get; set; }
        public string ResumeContent { get; set; }
        public string Skill { get; set; }
        public string MobileNumber2 { get; set; }
        public string emaiID2 { get; set; }
        public string MobileNumber3 { get; set; }
        public string emaiID3 { get; set; }

        public string CityID { get; set; }

        public List<ComboDeta> lstJobByRole { get; set; }

        public List<ComboDeta> lstCity { get; set; }

    }

    public class SignupRegistrationResponseInfo : BaseResponseInfo
    {
        public List<ComboDeta> lstJobTitle { get; set; }
        public SignUpOTP signUpOTP { get; set; }
        public List<ComboDeta> lstJobByRole { get; set; }

        public List<ComboDeta> lstCity { get; set; }
    }
    
    public class SignUpOTP
    {

        public string OTPMSG { get; set; }
        public string JobRegiID { get; set; }
        public Int64 MobiNumb { get; set; }
        public string JobFileRegiID { get; set; }

        
    }


    public class CompRegiInputInfo : BaseInputInfo
    {

        public string CompName { get; set; }
        public string CompURL { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string emaiID { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string CompType { get; set; }
        public string CompLocation { get; set; }
        public string CompAdd1 { get; set; }
        public string CompAdd2 { get; set; }
        public string CompAdd3 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string GSTID { get; set; }

        public string LandLine { get; set; }

    }

    public class CompRegiResponseInfo : BaseResponseInfo
    {

        
    }




}
