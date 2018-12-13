using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RaasP_Portal_Internal.Models.RaaSP_Architecture_Request_Account.CtsaInstitution;

namespace RaasP_Portal_Internal.Models.RaaSP_Architecture_Request_Account
{
    public class PrincipalInvestigatorEnvironment
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public AccountRequest accountrequest { get; set; }
        public SAMLUrl saml { get; set; }
    }
}
