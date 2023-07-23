using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Registers
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string? Name { get; set; }
        [MinLength(5)]
        public string? Password { get; set; }
        public string? Quistion { get; set; }
        [MinLength(3)]
        public string? Answer { get; set; }
    }
}
