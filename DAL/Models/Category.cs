using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category:BaseModel
    {
      
        public virtual ICollection<Products>? Products { get; set; }
    }
}
