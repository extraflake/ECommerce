using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("tb_m_item_photo")]
    public class ItemPhoto
    {
        [Key]
        public int Id { get; set; }
        public string Photo { get; set; }

        [ForeignKey("Item")]
        public int Item_Id { get; set; }
        public Item Item { get; set; }
    }
}
