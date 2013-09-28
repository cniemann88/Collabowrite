using Collabowrite.Shared.DataContracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collabowrite.ResourceAccess.DbAccessor
{

    public class Db : DbContext
    {
        public Db()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["CollabowriteDB"].ConnectionString);
            cs.InitialCatalog = "CollabowriteDB";

            Database.Connection.ConnectionString = cs.ConnectionString;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<GameInformation> GameInformations { get; set; }
    }
}
