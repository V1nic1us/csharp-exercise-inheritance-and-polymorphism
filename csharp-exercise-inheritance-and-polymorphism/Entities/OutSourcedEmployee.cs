using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_inheritance_and_polymorphism.Entities
{
    internal class OutSourcedEmployee: Employee
    {
        public double AdditionalChange { get; set; }
        public OutSourcedEmployee() { }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalChange):base(name, hours, valuePerHour)
        {
            AdditionalChange = additionalChange;
        }

        public override double payment()
        {
            return base.payment() + AdditionalChange * 1.10;
        }
    }
}
