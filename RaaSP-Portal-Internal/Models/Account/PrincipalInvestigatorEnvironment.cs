using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaasP_Portal_Internal.Models;
using static RaasP_Portal_Internal.Models.CtsaInstitution;

namespace RaasP_Portal_Internal.Models
{
    public class PrincipalInvestigatorEnvironments
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public Request accountrequest { get; set; }
        public SAMLUrl saml { get; set; }
    }
}
