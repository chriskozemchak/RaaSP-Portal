using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaaSP_Portal_API.Models
{
    interface IModelBase
{
        string Id { get; set; }
        string CreatedDate { get; set; }
        string ModifiedDate { get; set; }
        string Active { get; set; }
    }
}
