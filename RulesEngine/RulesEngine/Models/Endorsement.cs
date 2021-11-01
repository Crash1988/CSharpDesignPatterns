using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.RulesEngine
{
    class Endorsement
    {
        public int EndorsementId { get; set; }
        public string EndorsementCode { get; set; } = null!;
        public string EndorsementDescription { get; set; } = null!;

    }
}
