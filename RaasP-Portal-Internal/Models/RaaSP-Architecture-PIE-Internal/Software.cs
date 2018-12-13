using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class Software
    {
        public int ID { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }

        public Software(int ID, string ModifiedDate, string CreatedDate, Boolean Active)
        {
            this.ID = ID;
            this.ModifiedDate = ModifiedDate;
            this.CreatedDate = CreatedDate;
            this.Active = Active;
        }

    }

    

    
}
