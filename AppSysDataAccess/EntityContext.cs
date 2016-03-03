using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModel;

namespace AppSysDataAccess
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("name=DbConnectionString") { }
        public DbSet<ClinicList> ClinicLists { get; set; }
    }
}
