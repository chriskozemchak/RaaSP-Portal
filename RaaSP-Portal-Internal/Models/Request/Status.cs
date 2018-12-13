using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class Status
    {
        public int ID { get; set; }
        public string StatusName { get; set; }
        public string ModifiedDate { get; set; }
        public int RequestId { get; set; }
        public Boolean Active { get; set; }

    }
}
