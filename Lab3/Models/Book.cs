using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    public partial class Book
    {
        public Book()
        {
            Inventories = new HashSet<Inventory>();
        }

        [Key]
        [Column("ISBN13")]
        public long Isbn13 { get; set; }
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string Language { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public double? Rating { get; set; }
        [Column("AuthorID")]
        public int? AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Books")]
        public virtual Author? Author { get; set; }
        [InverseProperty(nameof(Inventory.IsbnNavigation))]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
