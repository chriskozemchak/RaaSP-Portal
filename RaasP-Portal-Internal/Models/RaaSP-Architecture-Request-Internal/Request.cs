using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models.RaaSP_Architecture_Request_Internal
{
    public class Request
    {
        public int ID { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public AccountRequest accountrequest { get; set; }
        public PIERequest pierequest { get; set; }
    }
}
