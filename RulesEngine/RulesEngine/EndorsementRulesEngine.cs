namespace RulesEngine.RulesEngine
{
    class EndorsementRulesEngine
    {
        public readonly IEnumerable<IRule?> _Rules;
        public EndorsementRulesEngine()
        {
            var ruleType = typeof(IRule);
            _Rules = GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule) ?? Enumerable.Empty<IRule?>();
        }

        public void ExecuteAllRules(InputModel i, List<Endorsement> e)
        {

            _Rules.Where(x => x != null)
                .ToList()
                .ForEach(x => x!.Execute(i, e));
        }
    }
}
