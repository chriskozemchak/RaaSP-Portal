using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public abstract class Request
    {
        public int ID { get; set; }
        public RequestType Type { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        
    }
}
