using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDbContext>());
        }

        public DbSet<User> Users { get; set; }
    }
}
