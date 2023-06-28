using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Models
{
    public class SocialMediaContext:DbContext
    {
        public DbSet<User> User { get; set; }

        public SocialMediaContext(DbContextOptions<NorthwindContext> options) :
        //ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString
            base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SocialMedia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }
    }
}
