
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.RulesEngine.Rules
{
    class MoreThan30Workers : IRule
    {
        public int Priority { get; } = 1;
        public PolicyNumber PolicyNumberRule { get; } = PolicyNumber.D71132;


        public bool CanExecute(InputModel input)
        {
            return PolicyNumberRule == input.PolicyNumber;
        }

        public void Execute(InputModel input, List<Endorsement> endorsements)
        {
            Console.WriteLine("Executing MoreThan30Workers rule ... ");
            if (input.EmployeeCount > 30)
            {
                endorsements.Add(
                    new Endorsement
                    {
                        EndorsementId = 1,
                        EndorsementCode = "E432B",
                        EndorsementDescription = "Worker Protection for more than 30 Employees"
                    });
            }
        }
    }
}
