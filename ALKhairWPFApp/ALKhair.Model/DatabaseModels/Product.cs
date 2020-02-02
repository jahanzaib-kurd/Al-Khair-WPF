using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models.DatabaseModels
{
    public class Product
    {
        public int ID { get; set; }

        public string Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Scheme { get; set; }
        public string UnitOfMeasure { get; set; }
        public double Units { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public double InvoicePrice { get; set; }
        public double RetailPrice { get; set; }
        public double Tax { get; set; }


        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

    }
}
