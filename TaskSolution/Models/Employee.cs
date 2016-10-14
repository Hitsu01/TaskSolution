using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TaskSolution.Models
{

    [XmlInclude(typeof(EmployeeFixedPayment)), XmlInclude(typeof(EmployeeHourlyPayment))]
    [Serializable]
    [KnownType(typeof(EmployeeFixedPayment))]
    [KnownType(typeof(EmployeeHourlyPayment))]

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee() { }
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract double GetAverageSalary();
    }
}
