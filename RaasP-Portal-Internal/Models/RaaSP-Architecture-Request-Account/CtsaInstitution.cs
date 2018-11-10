using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_Internal.Models.RaaSP_Architecture_Request_Account
{
    public class CtsaInstitution
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SSOUrl { get; set; }
        public string CtsaInstitute { get; set; }
        public string Subscription { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public AccountRequest accountrequest { get; set; }

        public class SAMLUrl
        {
            public PrincipalInvestigatorEnvironment principalInvestigatorEnvironment { get; set; }
            public CtsaInstitution inst;
            public SAMLUrl() { }

            public SAMLUrl(CtsaInstitution inst)
            {
                   this.inst = inst;
            }
        }
         
    }
}
