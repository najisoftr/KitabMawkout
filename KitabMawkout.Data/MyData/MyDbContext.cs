using Microsoft.EntityFrameworkCore;

namespace KitabMawkout.Data.MyData
{
    public class MyDbContext : DbContext
    {

        private static string GetDataBasePath()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(folder, "kitabMawkout.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={GetDataBasePath()}");
        }

        //tables
        public DbSet<MySetting> MySettings { get; set; }
    }
}
