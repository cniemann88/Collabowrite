using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collabowrite.Shared.DataContracts
{
    public class User : DatabaseBase
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
    }
}
