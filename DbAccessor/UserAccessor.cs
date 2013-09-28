using Collabowrite.Shared.DataContracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collabowrite.ResourceAccess.DbAccessor
{
    public class UserAccessor
    {
        public void CreateManyUser(List<User> users)
        {
            using (var db = new Db()) 
            {
                foreach (var u in users)
                {
                    db.Set<User>().Add(u);
                }
                db.SaveChanges();
            }
        }
    }
}
