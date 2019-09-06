using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    [Table("Users")]
    public class UserModelDTO
    {
        public long Id { get; set; }        
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CRN { get; set; }
        public string Phone { get; set; }

        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public string ActivationToken { get; set; }
        public bool IsActive { get; set; }
    }
}
