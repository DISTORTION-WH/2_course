using lab2._1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.models
{
    public class Faculty: Organization
    {
        protected List<JobTitle> jobTitles = new List<JobTitle>();    
        protected List<JobVacancy> jobVacancies = new List<JobVacancy>();
        protected List<Employee> employees = new List<Employee>();

        protected List<Department> departments = new List<Department>();

        public Faculty() { }

        public Faculty(Faculty faculty)
        {
            departments = faculty.departments;
        }

        public Faculty(string name, string shortName, string address)
        {
            Name = name;
            ShortName = shortName;
            Address = address;
        }

        public int AddDepartment(Department department)
        {
            departments.Add(department);
            return department.Id;
        }

        public bool DelDepartment(int id)
        {
            Department departmentToRemove = departments.FirstOrDefault(d => d.Id == id);
            if (departmentToRemove != null)
            {
                return departments.Remove(departmentToRemove);
            }
            return false;
        }

        public bool UpdDepartment(Department department) 
        {   
            int index = departments.FindIndex(d => d.Id == department.Id);
            if (index != -1)
            {
                departments[index] = department;
                return true;
            }
            return false;
        }

        public void PrintInfo()
        {
            foreach (Department department in departments)
            {
                Console.WriteLine(department);
            }
            Console.WriteLine("------------------------------");

            foreach (JobVacancy item in jobVacancies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");
        }

        private bool verDepartment(int id)
        {
            return departments.Any(d => d.Id == id);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Faculty ID: {Id}");
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"ShortName: {ShortName}");
            sb.AppendLine($"Address: {Address}");

            sb.AppendLine("Departments:");
            foreach (Department department in departments)
            {
                sb.AppendLine(department.ToString());
            }
            sb.AppendLine("------------------------------");

            return sb.ToString();
        }
    }
}
