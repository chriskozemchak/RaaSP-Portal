using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;


namespace RaaSP_Portal_DataAccess
{
    public class RaaSPDBContext : DbContext
    {

        public DbSet<Models.Environment.Info> Environments { get; set; }
        public DbSet<Models.Request.User> Users { get; set; }
    }
}


