using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models.DatabaseModels
{
    public class Inventory
    {
        public int ID { get; set; }
        public string ReferenceID { get; set; }
        public string ProductID { get; set; }
        public double Quantity { get; set; }
        public double Tonage { get; set; }
        public string Type { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
