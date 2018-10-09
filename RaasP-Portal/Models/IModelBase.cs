using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaasP_Portal_External.Models
{
     interface IModelBase
{
    string Id { get; set; }
    string CreatedDate { get; set; }
    string ModifiedDate { get; set; }
    string Active { get; set; }
    string CreatedById { get; set; }
    string ModifiedById { get; set; }
    
}

}
