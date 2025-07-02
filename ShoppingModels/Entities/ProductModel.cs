using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModels.Entities
{
    public class ProductModel
    {
        public int ID{ get; set; }
        public string? ProductName { get; set; }
        public int Quentity { get; set; }
        public Double Price { get; set; }

        public string? Description { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;




    }
}
