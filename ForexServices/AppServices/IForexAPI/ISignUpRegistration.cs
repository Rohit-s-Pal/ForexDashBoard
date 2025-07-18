using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexINFOAPI;

namespace IForexAPI
{
    
    public interface ISignUpRegistration
    {
        SignupRegistrationResponseInfo GetSignUpRegistration(SignupRegistrationInputInfo InputInfo);
        SignupRegistrationResponseInfo SaveSignUpRegistration(SignupRegistrationInputInfo InputInfo);
        LoginResponseInfo ValidUserLogin(LoginInputInfo inputValue);

        CompUserResponseInfo CompanyCredential(LoginInputInfo inputValue);

        CompRegiResponseInfo CompRegistration(CompRegiInputInfo inputValue);

     



    }
}
