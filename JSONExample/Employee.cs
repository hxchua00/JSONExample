using System;

namespace JSONExample
{
    class Employee
    {
        public string Name { get; set; }
        public Guid ID { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        //Must have default constructor for JSON, include it if have parameterised contructors
        public Employee() { }
    }
}
