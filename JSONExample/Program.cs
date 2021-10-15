using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JSONExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                ID = Guid.NewGuid(),
                Name = "Han",
                Address = "Platform 9 & 3/4",
                Designation = "CEO",
                Salary = 1000000000,
            };
            Employee emp1 = new Employee()
            {
                ID = Guid.NewGuid(),
                Name = "HanXuan",
                Address = "Diagon Alley, Three Broomsticks",
                Designation = "CTO",
                Salary = 1000000000,
            };

            List<Employee> empList = new List<Employee>();
            empList.Add(emp);
            empList.Add(emp1);

            string empJson = JsonConvert.SerializeObject(empList);
            //File.Create("Employee.Json");
            File.WriteAllText("Employee.Json", empJson);
            
            //Deserialize same type of object, Eg SerializeObject(List<>) , DeserializeObject(List<>)
            List<Employee> empTemp = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("Employee.Json"));

            string empJson1 = JsonConvert.SerializeObject(empTemp);
            File.WriteAllText("Employee.Json", empJson1);
            Console.ReadLine();
        }
    }
}
