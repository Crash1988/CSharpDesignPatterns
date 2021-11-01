namespace RulesEngine.RulesEngine.Rules
{
    class MoreThan30Workers : IRule
    {
        public int Priority { get; } = 1;

        public bool CanExecute(InputModel input) =>
            PolicyNumber.D71132 == input.PolicyNumber
            && input.EmployeeCount > 30;
        public void Execute(List<Endorsement> endorsements)
        {
            Console.WriteLine("Executing MoreThan30Workers rule ... ");
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
