using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CCA.Common.Models.PostData.Register;
using CCA.Common.Models.ReturnData.Register;
using System.Threading.Tasks;

namespace CCA.Web.HttpHelper
{
    public class Register : HttpHelperBase
    {
        async public static Task<CheckPasswordReturnData> CheckPassword(string password)
        {
            CheckPasswordPostData pd = new CheckPasswordPostData() { Password = password };
            var ret = await ApiCallPostAsync<CheckPasswordReturnData>("register/checkpassword", pd);
            return ret;
        }

        async public static Task<CheckEmailReturnData> CheckEmail(string email)
        {
            CheckEmailPostData pd = new CheckEmailPostData() { EmailAddress = email };
            var ret = await ApiCallPostAsync<CheckEmailReturnData>("register/checkemail", pd);
            return ret;
        }
    }
}