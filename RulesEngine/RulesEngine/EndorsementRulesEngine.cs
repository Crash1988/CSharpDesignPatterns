using RulesEngine.RulesEngine;
using RulesEngine.RulesEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.RulesEngine
{
    class EndorsementRulesEngine
    {
        public readonly List<IRule> _Rules;
        public EndorsementRulesEngine()
        {
            _Rules = new List<IRule> {
                new MoreThan30Workers(),
            };
        }

        public void ExecuteAllRules(InputModel i, List<Endorsement> e) { 
        
            _Rules.ForEach(x => x.Execute(i,e));
        }
    }
}
