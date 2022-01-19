using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        public int StoreId { get; set; }
        [Key]
        [Column("ISBN")]
        public long Isbn { get; set; }
        public int Stock { get; set; }

        [ForeignKey(nameof(Isbn))]
        [InverseProperty(nameof(Book.Inventories))]
        public virtual Book IsbnNavigation { get; set; } = null!;
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Inventories")]
        public virtual Store Store { get; set; } = null!;
    }
}
