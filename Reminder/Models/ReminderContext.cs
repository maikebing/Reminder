using SQLite.CodeFirst;
using System.Data.Entity;

namespace Reminder.Models
{
    public class ReminderContext : DbContext
    {
        public virtual DbSet<Memo> Memo { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ReminderContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}
