﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Solid
{
    class InterfaceSegregation
    {
        // Definition: states that a class must not have to implement any interface element
        // that is not required by the particular class. 

        public interface IWorker
        {
            string ID { get; set; }
            string Name { get; set; }
            string Email { get; set; }
            float MonthlySalary { get; set; }
            float OtherBenefits { get; set; }
            float HourlyRate { get; set; }
            float HoursInMonth { get; set; }
            float CalculateNetSalary();
            float CalaculateWorkedSalary();
        }

        public class FullTimeEmployee : IWorker
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public float MonthlySalary { get; set; }
            public float OtherBenefits { get; set; }
            public float HourlyRate { get; set; }
            public float HoursInMonth { get; set; }
            public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
            public float CalaculateWorkedSalary() => throw new NotImplementedException();
        }

        public class ContractEmployee : IWorker
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public float MonthlySalary { get; set; }
            public float OtherBenefits { get; set; }
            public float HourlyRate { get; set; }
            public float HoursInMonth { get; set; }
            public float CalculateNetSalary() => throw new NotImplementedException();
            public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
        }


        //-------------------------------------------------------
        //------------------- Best practices --------------------
        //-------------------------------------------------------

        public interface IBaseWorker
        {
            string ID { get; set; }
            string Name { get; set; }
            string Email { get; set; }
        }

        public interface IFullTimeWorkerSalary : IBaseWorker
        {
            float MonthlySalary { get; set; }
            float OtherBenefits { get; set; }
            float CalculateNetSalary();
        }

        public interface IContractWorkerSalary : IBaseWorker
        {
            float HourlyRate { get; set; }
            float HoursInMonth { get; set; }
            float CalaculateWorkedSalary();
        }


        public class FullTimeEmployeeFixed : IFullTimeWorkerSalary
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public float MonthlySalary { get; set; }
            public float OtherBenefits { get; set; }
            public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
        }

        public class ContractEmployeeFixed : IContractWorkerSalary
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public float HourlyRate { get; set; }
            public float HoursInMonth { get; set; }
            public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
        }
    }
}
