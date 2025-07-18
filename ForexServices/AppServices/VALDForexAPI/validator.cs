using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;
//using NET.Shared;

namespace VALDForexAPI
{
    public class Validator
    {

        public ValidResponseInfo RecruiterInputValidate(LoginInputInfo inputInfo)
        {
            ValidResponseInfo ResponseInfo = new ValidResponseInfo();
            //OutputDictionary<string, string> validmsg = new OutputDictionary<string, string>();

            List<validmessage> lstvalidmessage = new List<validmessage>();
            bool valid_status;

            ResponseInfo.Status = "1";
            try
            {
                //if ((inputInfo.Name) == "" || (inputInfo.Name) == null)
                //{
                //    validmessage VLDMSG = new validmessage();
                //    VLDMSG.validMSG = "Please enter valid name";
                //    ResponseInfo.Status = "0";
                //    lstvalidmessage.Add(VLDMSG);
                //}
                if ((inputInfo.EmailID) == "" || (inputInfo.EmailID) == null)
                {
                    validmessage VLDMSG = new validmessage();
                    VLDMSG.validMSG = "Please enter valid email-ID";
                    ResponseInfo.Status = "0";
                    lstvalidmessage.Add(VLDMSG);
                }
                else
                {
                    inputvalidator inpvalidator = new inputvalidator();
                    valid_status = inpvalidator.IsValidEmail(inputInfo.EmailID);
                    if (valid_status == false)
                    {
                        validmessage VLDMSG = new validmessage();
                        VLDMSG.validMSG = "Email ID Submitted is not in correct format.";
                        ResponseInfo.Status = "0";
                        lstvalidmessage.Add(VLDMSG);
                    }
                }

                //if ((inputInfo.MobileNumber) == "" || (inputInfo.MobileNumber) == null)
                //{
                //    validmessage VLDMSG = new validmessage();
                //    VLDMSG.validMSG = "Please enter mobile number";
                //    ResponseInfo.Status = "0";
                //    lstvalidmessage.Add(VLDMSG);
                //}
                if ((inputInfo.Password) == "" || (inputInfo.Password) == null)
                {
                    validmessage VLDMSG = new validmessage();
                    VLDMSG.validMSG = "Please enter valid password";
                    ResponseInfo.Status = "0";
                    lstvalidmessage.Add(VLDMSG);
                }

                ResponseInfo.lstvalidmessage = lstvalidmessage;
            }
            catch (Exception)
            {

                throw;
            }

            return ResponseInfo;
        }


    }


}
