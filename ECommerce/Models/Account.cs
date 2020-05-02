using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("tb_m_account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }

        public virtual User User { get; set; }
    }
}
