using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA.Common.Models.ReturnData
{
    public class ReturnDataBase
    {
        public string Result { get; set; }

        public string Message { get; set; }

        public ReturnDataBase()
        {
            Result = "OK";
            Message = "API Call Success";
        }
        public void SetError(string msg)
        {
            Result = "ERR";
            Message = msg;
        }

        public void SetError(Exception ex)
        {
            StringBuilder str = new StringBuilder();
            Exception cur = ex;

            while (cur != null)
            {
                str.AppendLine(cur.Message);
                str.AppendLine("Detail:");
                str.AppendLine(cur.StackTrace);

                cur = cur.InnerException;
            }

            Result = "ERR";
            Message = str.ToString();
        }

        public void SetOk(string msg = "")
        {
            Result = "OK";
            Message = msg;
        }
    }
}
