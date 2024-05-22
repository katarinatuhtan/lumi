using System.Collections.Generic;

namespace Lumi.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}