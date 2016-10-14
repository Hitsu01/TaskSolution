using System;

namespace TaskSolution.Models
{
    [Serializable]
    public class EmployeeFixedPayment : Employee
    {
     
        public double FixedPayment { get; set; }

        public EmployeeFixedPayment() { }

        public EmployeeFixedPayment(int id, string name, double fPayment) : base(id, name)
        {
            this.FixedPayment = fPayment;
        }

        public override double GetAverageSalary()
        {
            return FixedPayment;
        }
    }
}
