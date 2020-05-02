using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    [Table("tb_m_item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Supplier")]
        public int Supplier_Id { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public Category Category { get; set; }
    }
}
