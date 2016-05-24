using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA.Common.Models.ReturnData.Register
{
    public class CheckPasswordReturnData : ReturnDataBase
    {
        public string CheckPasswordResult { get; set; }

        public bool IsValid { get; set; }
    }
}
