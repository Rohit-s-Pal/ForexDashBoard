using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForexAPI;
using System.Text.RegularExpressions;
using ForexINFOAPI;

namespace ForexAPI
{
    public class InputLoginValidatorResponces
    {
        public InputValidatorResponces UserLoginDetails(LoginInputInfo inputinfo)
        {
            //string OMGMSG = null;
            int Count = 0;
            string msg = " \n";
         
          
            //string MSGDeta = "|";

            InputValidatorResponces Responcesinfo = new InputValidatorResponces();
            if(inputinfo.AuthKey==null)
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Not Valid Access" + msg;
                Count = 1;
            }
            if (inputinfo.APPProcType==0 || inputinfo.APPProcType>2 || String.IsNullOrEmpty(inputinfo.APPProcType.ToString()))
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG + "Please Enter Valid APPProcType" + msg;
                Count = 1;
            }
            if (inputinfo.UserType == 0 || inputinfo.UserType > 3 || String.IsNullOrEmpty(inputinfo.UserType.ToString()))
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid UserType" + msg;
                Count = 1;

            }
            
            if (inputinfo.ProcType ==0 || inputinfo.ProcType>2 || String.IsNullOrEmpty(inputinfo.ProcType.ToString()))
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid Proctype" + msg; /* XML File - Unique Value */
                Count = 1;
            }
             if (inputinfo.EmailID == null)
            {
                Responcesinfo.IPVStatus = 0;

                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid EmailID" + msg;
                Count = 1;
            }
           
             if (inputinfo.Password == null)
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid Password" + msg;
                Count = 1;
            }
            
             if (String.IsNullOrEmpty(inputinfo.CompID.ToString()))
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG   + "Please enter valid CompID" + msg;
                Count = 1;
            }
            if (inputinfo.EmailID != null)
            {
                if(Count==0)
                {
                    Responcesinfo.IPVStatus = EmailValid(inputinfo.EmailID);
                    if (Responcesinfo.IPVStatus == 1)
                    {
                        //Responcesinfo.IPVStatus = 0;
                    }
                    else
                    {
                        Responcesinfo.IPVStatus = 0;
                        Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid EmailID" + msg;
                    }

                }
                else
                {
                    Responcesinfo.IPVStatus = 0;
                    Responcesinfo.IPVMSG = Responcesinfo.IPVMSG  + "Please enter valid EmailID" + msg;
                  
                }

             
            }
            if (Responcesinfo.IPVStatus ==0)
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = Responcesinfo.IPVMSG;
            }

            else
            {
                Responcesinfo.IPVStatus = 1;
                Responcesinfo.IPVMSG = "Data Is Sucessfully Validated";
            }

          
            return Responcesinfo;
        }
        private int EmailValid(string email)
        {
            int EmailStatus;
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(emailRegex);
            if (!re.IsMatch(email))
            {
                EmailStatus = 0;
            }
            else
            {
                EmailStatus = 1;
            }
                return EmailStatus;
        }

        private int InputMobValid(string MobileNo)
        {
            int MobileStatus;

            string MobileExpression = @"^\([8-9]{1})([012346789]{1})([0-9]{8})$";
            Regex re = new Regex(MobileExpression);
            if(MobileNo.Length==10)
            {
                if (!re.IsMatch(MobileNo))
                {
                    MobileStatus = 0;
                }
                else
                {
                    MobileStatus = 1;
                }
            }
            else
            {
                MobileStatus = 0;
            }
           

            //            (@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            //}/^ ([8 - 9]{ 1})([012346789]{ 1})([0 - 9]{ 8})$/
            return MobileStatus;
        }

    }
}