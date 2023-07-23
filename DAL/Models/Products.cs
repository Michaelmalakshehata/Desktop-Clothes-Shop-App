using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Products : BaseModel
    {
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string? Detailes { get; set; }
        [Required]
        public byte[]? ProductImg { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
