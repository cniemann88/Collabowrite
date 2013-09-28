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
            UserAccessor ua = new UserAccessor();
            ua.CreateManyUser(users);
        }

        public List<User> FindAllUsers()
        {
            UserAccessor ua = new UserAccessor();
            return ua.FindAll().ToList();
        }

        public void UpdateUser(User user)
        {
            UserAccessor ua = new UserAccessor();
            ua.Update(user);
        }
    }
}
