using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.View_Models
{
    public class CategoryNames
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public override string ToString() => this.Name;
    }
}
