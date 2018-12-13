using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models
{
    public class PrincipalInvestigator
    {
        public int ID { get; set; }
        public PrincipalInvestigatorEnvironment principalInvestigatorEnvironment { get; set; }
        public PIERequest pierequest { get; set; }
    }
}
