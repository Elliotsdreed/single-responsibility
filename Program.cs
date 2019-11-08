using System;

namespace single_responsidsoudyg
{
    class Program
    {
        static void Main(string[] args)
        {
             Employee employee = new Employee 
            {  
                FirstName = "John",  
                LastName = "Deo", 
                Email = "jdeo@sample.com"  
            };  
            EmployeeService employeeService = new EmployeeService();  
            employeeService.EmployeeRegistration(employee).Wait();  
            Console.ReadKey(); 
        }
        
    }
}
