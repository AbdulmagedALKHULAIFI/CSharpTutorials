using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Solid
{
    class DependcyInversion
    {

        //Definition: high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions.
        //Secondly, abstractions should not depend upon details. Details should depend upon abstractions.


        class SalaryCalculator
        {
            public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
        }

        public class EmployeeDetails
        {
            public int HoursWorked { get; set; }
            public int HourlyRate { get; set; }
            public float GetSalary()
            {
                var salaryCalculator = new SalaryCalculator();
                return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
            }
        }

        //Violation: the higher-level class EmployeeDetails is directly depending upon the lower level SalaryCalculator class.


        //-------------------------------------------------------
        //------------------- Best practices --------------------
        //-------------------------------------------------------

        public interface ISalaryCalculator
        {
            float CalculateSalary(int hoursWorked, float hourlyRate);
        }

        public class SalaryCalculatorModified : ISalaryCalculator
        {
            public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
        }

        public class EmployeeDetailsModified
        {
            private readonly ISalaryCalculator _salaryCalculator;
            public int HoursWorked { get; set; }
            public int HourlyRate { get; set; }
            public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
            {
                _salaryCalculator = salaryCalculator;
            }
            public float GetSalary()
            {
                return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
            }
        }
    }
}
