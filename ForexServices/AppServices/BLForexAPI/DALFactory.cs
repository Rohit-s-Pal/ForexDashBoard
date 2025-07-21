using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IForexAPI;


using DALForexAPI;

namespace BLForexApi
{
    internal class DALFactory
    {
        internal DALFactory()
        {

        }
       


       


        internal static IAgentPostProperty GetTemplateData()
        {
            IAgentPostProperty IAgentPostProperty = new AgentPostPropertyDAL();
            return IAgentPostProperty;
        }


        internal static IPropUserLogin GetPropUserDAL()
        {
            IPropUserLogin IPropUserLogin = new PropUserDAL();
            return IPropUserLogin;
        }
        
        internal static IForexLogin GetForexUserDAL()
        {
            IForexLogin IForexLogin = new ForexLoginDAL();
            return IForexLogin;
        }

        internal static IRecruiter GetRecruiterDAL()
        {
            IRecruiter IRecruiter = new RecruiterDAL();
            return IRecruiter;
        }
        internal static IDashboard GetDashboardDAL()
        {
            IDashboard IDashboard = new DashboardDAL();
            return IDashboard;
        }

        internal static IPropertyPage GetPropertyPageDAL()
        {
            IPropertyPage IPropertyPage = new PropertyPageDAL();
            return IPropertyPage;
        }

        internal static IIPAddress InsertIPAddressDAL()
        {
            IIPAddress IIPAddress = new IPAddressDAL();
            return IIPAddress;
        }




        internal static ICMSUser GetCMSUserDAL()
        {
            ICMSUser ICMSUser = new CMSUserDAL();
            return ICMSUser;
        }
    }
}
