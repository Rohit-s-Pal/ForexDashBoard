
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using BLForexApi;
using BLForexApi;
using IForexAPI;



namespace ForexAPI
{
    public class Factory
    {
       

       
        

        public static IIPAddress InsertIPAddress()
        {
            IIPAddress iIPAddress = null;
            try
            {
                iIPAddress = new IPAddressBL();
            }
            catch
            {
                throw;
            }
            return iIPAddress;
        }


        public static IPropertyPage GetPropertydata()
        {
            IPropertyPage iPropertyPage = null;
            try
            {
                iPropertyPage = new PropertyPageBL();
            }
            catch
            {
                throw;
            }
            return iPropertyPage;
        }
        
        public static IPropUserLogin GetPropUserLogin()
        {
            IPropUserLogin iPropUserLogin = null;
            try
            {
                iPropUserLogin = new PropUserBL();
            }
            catch
            {
                throw;
            }
            return iPropUserLogin;
        }

        public static IAgentPostProperty GetTemplateData()
        {
            IAgentPostProperty iAgentPostProperty = null;
            try
            {
                iAgentPostProperty = new AgentPostPropertyBL();
            }
            catch
            {
                throw;
            }
            return iAgentPostProperty;
        }





    }
}