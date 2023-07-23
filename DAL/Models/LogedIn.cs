using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LogedIn
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string? Name { get; set; }
        public bool logged { get; set; } = false;
    }
}
