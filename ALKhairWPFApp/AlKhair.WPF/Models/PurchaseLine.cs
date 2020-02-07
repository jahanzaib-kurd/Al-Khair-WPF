using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models
{
    public class PurchaseLine
    {
        public int ID { get; set; }
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        

        public double Cost { get; set; }
        public double Price { get; set; }
        public double InvoicePrice { get; set; }
        public double RetailPrice { get; set; }
        public double Tax { get; set; }
        public int Quantity { get; set; }
        public double Tonage { get; set; }
        public double Amount { get; set; }
        
        public double AmountIncTax { get; set; }
        

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
