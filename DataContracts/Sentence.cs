using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collabowrite.Shared.DataContracts
{
    public class Sentence : DatabaseBase
    {
        public string StoryUIDD { get; set; }

        public string Text { get; set; }
    }
}
