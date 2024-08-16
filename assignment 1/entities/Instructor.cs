using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1.entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }

    }
}
