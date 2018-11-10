using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class PIEType
    {
        public int ID { get; set; }
        public string PIETypeName { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public PrincipalInvestigatorEnvironment pie { get; set; }

    }
}
