using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForexAPI;
using ForexINFOAPI;

namespace ForexAPI
{

    public class InputValidator
    {

       public InputValidatorResponces JobDetails(HomeInputInfo inputinfo)
        {

            InputValidatorResponces Responcesinfo = new InputValidatorResponces();

            if (inputinfo.JobSkill=="")
            {
                Responcesinfo.IPVStatus = 0;
                Responcesinfo.IPVMSG = "Please enter valid JobSkill";
            }
            return Responcesinfo;
        }

    }

  

     
}