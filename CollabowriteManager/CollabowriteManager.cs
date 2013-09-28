using Collabowrite.Shared.DataContracts;
using Collabowrite.ResourceAccess.DbAccessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabowriteManager
{
    public class CollabowriteManager
    {
        public void CreateManyUser(List<User> users)
        {
            UserAccessor userAccessor = new UserAccessor();
            userAccessor.CreateManyUser(users);
        }
    }
}
