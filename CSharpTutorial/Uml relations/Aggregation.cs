using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Uml_relations
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }

    class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public University(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }
    }

    class ProgramAggregation
    {
        public ProgramAggregation(string[] args)
        {
            University university = new University("University of ABC");

            Department department1 = new Department("Department of Computer Science");
            Department department2 = new Department("Department of Mathematics");

            university.Departments.Add(department1);
            university.Departments.Add(department2);

            Console.WriteLine("University Name: " + university.Name);
            Console.WriteLine("Departments:");

            foreach (Department department in university.Departments)
            {
                Console.WriteLine(department.Name);
            }

            Console.ReadLine();
        }
    }

}
