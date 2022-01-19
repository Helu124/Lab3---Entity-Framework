using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    [Keyless]
    public partial class VTitlarPerFörfattare
    {
        [StringLength(511)]
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public int? Titles { get; set; }
        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
