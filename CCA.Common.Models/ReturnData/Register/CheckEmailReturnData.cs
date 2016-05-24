using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA.Common.Models.ReturnData.Register
{
    public class CheckEmailReturnData : ReturnDataBase
    {
        public string CheckEmailResult { get; set; }

        public bool IsValid { get; set; }
    }
}
