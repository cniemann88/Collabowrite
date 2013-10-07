using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collabowrite.Shared.DataContracts
{
    public class Story : DatabaseBase
    {
        //Populate this string with the order of sentences and with ',' separator
        public string SentenceUUID { get; set; }
    }
}
