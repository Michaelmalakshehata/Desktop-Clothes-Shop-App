using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DAL.View_Models
{
    public class ProductDetailes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        public string? Detailes { get; set; }
        public BitmapImage? ProductImg { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; } 
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? RestoreDate { get; set; }
        public string? CreateUserName { get; set; }
        public string? UpdateUserName { get; set; }
        public string? DeleteUserName { get; set; }
        public string? RestoreUserName { get; set; }
    }
}
