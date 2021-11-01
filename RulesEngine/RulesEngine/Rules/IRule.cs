using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.RulesEngine
{
    interface IRule
    {
        public int Priority { get; }
        public PolicyNumber PolicyNumberRule {  get; }
        bool CanExecute(InputModel input);
        void Execute(InputModel input, List<Endorsement> endorsements);
    }
}
