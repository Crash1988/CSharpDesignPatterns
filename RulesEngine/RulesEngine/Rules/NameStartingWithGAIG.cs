namespace RulesEngine.RulesEngine.Rules
{
    class NameStartingWithGAIG : IRule
    {
        public int Priority => 2;

        public bool CanExecute(InputModel input)
            => PolicyNumber.D71132 == input.PolicyNumber
                && input.State == "IL"
                && input.Name.StartsWith("GAIG");

        public void Execute(List<Endorsement> endorsements)
        {
            Console.WriteLine("Executing NameStartingWithBLM rule ... ");
            endorsements.Add(new Endorsement
            {
                EndorsementId = 1,
                EndorsementCode = "E4546",
                EndorsementDescription = "Endorsement for companies where Name Start with GAIG"
            });
        }
    }
}
