using System;

namespace TaskSolution.Models
{
    [Serializable]
    public class EmployeeHourlyPayment : Employee
    {
        private const double Multiplier = (8.0 * 20.8);
        public double HourlyRate { get; set; }

        public EmployeeHourlyPayment() { }
        public EmployeeHourlyPayment(int id, string name, double hourlyRate) : base(id, name)
        {
            this.HourlyRate = hourlyRate;
        }
        public override double GetAverageSalary()
        {
            return (Multiplier * HourlyRate);
        }
    }
}
