using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class PrincipalInvestigatorEnvironment : Request
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public VirtualMachine virtualmachine { get; set; }
        public Software software { get; set; }
        public PIEAccount pieaccount { get; set; }
        

    }
}
