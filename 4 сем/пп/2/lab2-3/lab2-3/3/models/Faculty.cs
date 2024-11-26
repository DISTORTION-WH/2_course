using lab2._1.classes;
using lab2._1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.models
{
    public class Faculty : Organization, IStaff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }

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
            department.Id = GenerateUniqueId(departments);
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

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public List<JobVacancy> GetJobVacancies()
        {
            return jobVacancies;
        }

        public int AddJobTitle(JobTitle jobTitle)
        {
            jobTitle.Id = GenerateUniqueId(jobTitles);
            jobTitles.Add(jobTitle);
            return jobTitle.Id;
        }

        public bool DelJobTitle(int id)
        {
            JobTitle jobTitleToRemove = jobTitles.FirstOrDefault(j => j.Id == id);
            if (jobTitleToRemove != null)
            {
                return jobTitles.Remove(jobTitleToRemove);
            }
            return false;
        }

        public void OpenJobVacancy(JobVacancy jobVacancy)
        {
            jobVacancy.Id = GenerateUniqueId(jobVacancies);
            jobVacancies.Add(jobVacancy);
        }

        public bool CloseJobVacancy(int id)
        {
            JobVacancy jobVacancyToRemove = jobVacancies.FirstOrDefault(j => j.Id == id);
            if (jobVacancyToRemove != null)
            {
                return jobVacancies.Remove(jobVacancyToRemove);
            }
            return false;
        }

        public Employee Recruit(JobVacancy jobVacancy, Person person)
        {
            Employee employee = new Employee(jobVacancy, person);

            employee.Id = GenerateUniqueId(employees);
            employees.Add(employee);
            return employee;
        }

        public bool Dismiss(int id, Reason reason)
        {
            Employee EmployeeToRemove = employees.FirstOrDefault(e => e.Id == id);
            if (EmployeeToRemove != null)
            {
                employees.Remove(EmployeeToRemove);
                return true;
            }

            return false;
        }

        private int GenerateUniqueId<T>(List<T> list) where T : class
        {
            int newId = 1;
            while (list.Any(item => (item as dynamic).Id == newId))
            {
                newId++;
            }
            return newId;
        }
        List<Employee> GetEmployees() {
            return employees;
        }
        List<JobTitle> GetJobTitles()
        {
            return jobTitles;
        }

        string PrintJobVacancies()
        {
            string data = "";

            foreach (JobVacancy jobVacancy in jobVacancies)
            {
                data += $"\n{jobVacancy.ToString()}";
            }

            return data;
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

            sb.AppendLine("Job Vacancies:");
            foreach (JobVacancy item in jobVacancies)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("------------------------------");

            sb.AppendLine("Employees:");
            foreach (Employee item in employees)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("------------------------------");

            return sb.ToString();
        }
    }
}
