using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("tb_m_item_detail")]
    public class ItemDetail
    {
        [Key]
        public int Serial { get; set; }

        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }
    }
}
