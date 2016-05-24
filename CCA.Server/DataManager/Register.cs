using CCA.Common.Models.PostData.Register;
using CCA.Common.Models.ReturnData.Register;
using CCA.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCA.Server.DataManager
{
    public static class Register
    {
        public static CheckPasswordReturnData CheckPassword(CheckPasswordPostData pd)
        {
            var ret = new CheckPasswordReturnData();

            try
            {
                

                //checks password strength
                if (string.IsNullOrEmpty(pd.Password))
                {
                    ret.IsValid = false;
                    ret.CheckPasswordResult = Resources.Register.Password_Invalid;
                    return ret;
                }
                    

                if (pd.Password.Length < 6)
                {
                    ret.IsValid = false;
                    ret.CheckPasswordResult = String.Format(Resources.Register.Password_TooShort, 6);
                    return ret;
                }

                ret.IsValid = true;
                ret.CheckPasswordResult = Resources.Register.Password_Valid;
            }
            catch(Exception ex)
            {
                ret.SetError(ex);
            }
            return ret;
            
        }

        public static CheckEmailReturnData CheckEmail(CheckEmailPostData pd)
        {
            CheckEmailReturnData ret = new CheckEmailReturnData();

            try
            {
                if (string.IsNullOrEmpty(pd.EmailAddress))
                {
                    ret.IsValid = false;
                    ret.CheckEmailResult = Resources.Register.Email_Invalid;
                    return ret;
                }

                using (CcaEntities ce = new CcaEntities())
                {
                    var any = ce.CcaUsers.Where(w => w.Email.ToLower() == pd.EmailAddress.ToLower()).Any();

                    if (any)
                    {
                        ret.IsValid = false;
                        ret.CheckEmailResult = Resources.Register.Email_Taken;
                        return ret;
                    }

                    ret.IsValid = true;
                    ret.CheckEmailResult = Resources.Register.Email_Valid;
                }
            }
            catch(Exception ex)
            {
                ret.SetError(ex);
            }
            return ret;
        }
    }
}