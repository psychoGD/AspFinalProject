using Microsoft.EntityFrameworkCore;

namespace App.Entities.Models
{
    public class SocialMediaContext : DbContext
    {

        public SocialMediaContext()
        {
            
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options) :
        //ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString
            base(options)
        {

        }
        public virtual DbSet<User> User { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
    }
}