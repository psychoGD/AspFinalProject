
using System.Data.Entity;

namespace App.DataAccess.Concrete.EfEntityFramework
{
    public class CarDBContext:DbContext
    {
        
        public CarDBContext() :
        //ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString
            base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

    }
}
