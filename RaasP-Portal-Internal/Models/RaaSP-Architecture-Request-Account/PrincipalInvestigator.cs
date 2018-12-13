using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models.RaaSP_Architecture_Request_Account
{
    public class PrincipalInvestigator
    {
        public int ID { get; set; }
        public PrincipalInvestigatorEnvironment principalInvestigatorEnvironment { get; set; }
        public PIERequest pierequest { get; set; }
    }
}
