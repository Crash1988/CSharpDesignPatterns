namespace RulesEngine.RulesEngine
{
    class PolicyNumber
    {
        public string Value { get; init; }
        public static PolicyNumber D11321 { get; } = new PolicyNumber("D11321");
        public static PolicyNumber D71132 { get; } = new PolicyNumber("D71132");

        public PolicyNumber(string value)
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PolicyNumber p = (PolicyNumber)obj;
                return Value == p.Value;
            }
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
