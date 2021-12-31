using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public bool IsComplete { get; set; }
    }
}
