using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine.RulesEngine
{
    class InputModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int EmployeeCount { get; set; }

        public PolicyNumber PolicyNumber = null!;
        public bool IsNewPolicy => PolicyNumber == PolicyNumber.D71132;

    }
}
