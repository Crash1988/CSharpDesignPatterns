// See https://aka.ms/new-console-template for more information

using RulesEngine.RulesEngine;

Console.WriteLine("Hello, World!");

var i = new InputModel
{
    Id = 1,
    Name = "Test",
    Description = "Description",
    EmployeeCount = 31,
    PolicyNumber = PolicyNumber.D71132
};

var rulesEngine = new EndorsementRulesEngine();
var e = new List<Endorsement>();
rulesEngine.ExecuteAllRules(i, e);
Console.WriteLine(e.Count());