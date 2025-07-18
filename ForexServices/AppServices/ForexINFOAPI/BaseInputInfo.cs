using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexINFOAPI
{
    public class BaseInputInfo : BaseInfo
    {
        public string? RoleID { get; set; }
        public string? AppID { get; set; }
        public string? AppUSERID { get; set; }
        public string? AppPASSWORD { get; set; }
        public string? IPAddress { get; set; }

        public string? SubIPAddress { get; set; }

      
        public string? Browser { get; set; }
        public string? BrowserVers { get; set; }

        //@SubIPAddress,@Location,@Browser,@BrowserVers

        public string? TimeStamp { get; set; }

        public Int64? CompID { get; set; } /*= 0 : Non pages 1: Employee  Employer  : ID 15789*/

        public Int64? UserID { get; set; }  /* Login after the User is validated */
        public string? AuthKey { get; set; }
        public int? APPProcType { get; set; }
        public int? UserType { get; set; }
        public int? ProcType { get; set; }
        public string? APIAuthKey { get; set; } /* After Login, APIAuthKey will be allocate, which will be additional Process to validate WebAPI */

        public string? latitude { get; set; }
        public string? longitude { get; set; }

        public string? googlemapsIP { get; set; }

        public string? Controller { get; set; }

        public string? Action { get; set; }


    }
    public class TempValues
    {
        public const string? AuthKey = "abcd";
        public const int APPProcType = 1;
        public const int UserType = 1;
        public const int Proctype = 1;
        public const string? AppID = "171";
        public const string? AppPASSWORD = "S";
        public const string? AppUSERID = "123";


    }

    public class ComboDeta
    {
        public string? ValueID { get; set; }

        public string? ValueDesc { get; set; }

    }

    public class DateRange
    {
        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

    }

    public class JwtToken
    {
        
        public string? UserID { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Issuer { get; set; }

        public string? Audience { get; set; }

    }

}
