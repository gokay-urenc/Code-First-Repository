using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Repository.DAL.Entities
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public short UnitsInStock { get; set; }
    }
}