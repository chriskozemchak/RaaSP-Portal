using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class VirtualMachine
    {
        public int ID { get; set; }
        public string VMName { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }

        public VirtualMachine (int ID, string VMName, string ModifiedDate, string CreatedDate, Boolean Active)
        {
            this.ID = ID;
            this.VMName = VMName;
            this.ModifiedDate = ModifiedDate;
            this.CreatedDate = CreatedDate;
            this.Active = Active;
        }
       
    }

    
}
