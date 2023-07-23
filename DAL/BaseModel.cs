using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string? Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }  
        public DateTime? DeleteDate { get; set; } 
        public DateTime? RestoreDate { get; set; }
        [Required]
        public string? CreateUserName { get; set; }
        public string? UpdateUserName { get; set; }
        public string? DeleteUserName { get; set; }
        public string? RestoreUserName { get; set; }
    }
}
