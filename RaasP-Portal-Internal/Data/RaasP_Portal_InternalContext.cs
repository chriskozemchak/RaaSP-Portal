using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaasP_Portal_Internal.Models;

namespace RaasP_Portal_Internal.Models
{
    public class RaasP_Portal_InternalContext : DbContext
    {
        public RaasP_Portal_InternalContext (DbContextOptions<RaasP_Portal_InternalContext> options)
            : base(options)
        {
        }

        public DbSet<RaasP_Portal_Internal.Models.Request> Request { get; set; }
    }
}
