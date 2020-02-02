using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models.DatabaseModels
{
    public class Purchase
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int BankID { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

    }
}
