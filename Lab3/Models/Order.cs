using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    [Keyless]
    public partial class Order
    {
        [Column("ProductID")]
        public long ProductId { get; set; }
        public int Author { get; set; }
        public int Customer { get; set; }

        [ForeignKey(nameof(Author))]
        public virtual Author AuthorNavigation { get; set; } = null!;
        [ForeignKey(nameof(Customer))]
        public virtual Customer CustomerNavigation { get; set; } = null!;
        [ForeignKey(nameof(ProductId))]
        public virtual Book Product { get; set; } = null!;
    }
}
