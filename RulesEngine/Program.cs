using RulesEngine.RulesEngine;

Console.WriteLine("Hello, World!");

var i = new InputModel
{
    Id = 1,
    Name = "Test",
    Description = "Description",
    Address = "123 Main",
    City = "Chicago",
    State = "IL",
    Zip = "60606",
    EmployeeCount = 31,
    PolicyNumber = PolicyNumber.D71132
};

var rulesEngine = new EndorsementRulesEngine();
var e = new List<Endorsement>();
rulesEngine.ExecuteAllExecutablesRules(i, e);
Console.WriteLine(e.Count);