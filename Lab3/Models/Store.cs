using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    public partial class Store
    {
        public Store()
        {
            Inventories = new HashSet<Inventory>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string StoreName { get; set; } = null!;
        [StringLength(255)]
        public string StoreAddress { get; set; } = null!;

        [InverseProperty(nameof(Inventory.Store))]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
