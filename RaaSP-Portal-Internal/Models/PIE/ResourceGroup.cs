using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class ResourceGroup
    {
        public int ID { get; set; }
        public string ResourceGroupName { get; set; }
        public string RoleName { get; set; }
        public string ADResourceGroup { get; set; }
        public string Subscription { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public PIEAccount pieaccount { get; set; }
    }
}
