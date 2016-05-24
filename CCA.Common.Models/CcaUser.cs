using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA.Common.Models
{
    public class CcaUser
    {
        [Key]
        public long CcaUserId { get; set; }

        public string CcaAccountId { get; set; }

        public string Email { get; set; }

        public string HashedPassword { get; set; }

        public string PasswordSalt { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateUpdated { get; set; }

        public string UpdatedBy { get; set; }
    }
}
