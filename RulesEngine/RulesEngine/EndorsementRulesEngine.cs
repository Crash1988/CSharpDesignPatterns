namespace RulesEngine.RulesEngine
{
    class EndorsementRulesEngine
    {
        public readonly IEnumerable<IRule?> _Rules;
        public EndorsementRulesEngine()
        {
            _Rules = GetType().Assembly.GetTypes()
                .Where(p => typeof(IRule).IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule) ?? Enumerable.Empty<IRule?>();
        }

        public void ExecuteAllExecutablesRules(InputModel i, List<Endorsement> e) =>
            _Rules.Where(r => r != null && r.CanExecute(i))
                .OrderBy(r => r!.Priority)
                .ToList()
                .ForEach(r => r!.Execute(i, e));

    }
}
