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
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationRead> NotificationReads { get; set; }
        /// <summary>
        /// Stores basic information about service members. The model is minimal and
        /// is primarily used by the KTVP form. Additional fields can be added as
        /// requirements evolve.
        /// </summary>
        public DbSet<ServiceMember> ServiceMembers { get; set; }
    }
}
