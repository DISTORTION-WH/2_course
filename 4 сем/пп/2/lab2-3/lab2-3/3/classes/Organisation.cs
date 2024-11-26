using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.classes
{
    using lab2._1.interfaces;
    using lab2._1.models;
    using System;
    using System.Collections.Generic;

    public class Organization : IStaff
    {
        private int _id;
        private string _name;
        private string _shortName;
        private string _address;
        private DateTime _timeStamp;

        public int Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public string ShortName
        {
            get { return _shortName; }
            protected set { _shortName = value; }
        }

        public string Address
        {
            get { return _address; }
            protected set { _address = value; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            protected set { _timeStamp = value; }
        }

        public Organization() { }
        public Organization(Organization organization)
        {
            this.Address = organization.Address;
            this.Name = organization.Name;
            this.ShortName = organization.ShortName;
            this.Address = organization.Address;
            this.TimeStamp = organization.TimeStamp;
        }

        public Organization(string name, string shortName, string address)
        {
            Name = name;
            ShortName = shortName;
            Address = address;
            TimeStamp = DateTime.Now;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.ShortName);
            Console.WriteLine(this.Address);
            Console.WriteLine(this.TimeStamp);
        }

        public List<JobVacancy> GetJobVacancies() {
            return new List<JobVacancy>();
        }

        public List<Employee> GetEmployees() {
            return new List<Employee>();
        }

        public List<JobTitle> GetJobTitles() {
            return new List<JobTitle>();
        }

        public int AddJobTitle(JobTitle jobTitle) {
            return 0;
        }

        public string PrintJobVacancies()
        {
            return "";
        }

        public bool DelJobTitle(int jobTitleId) {
            return true;
        }

        public void OpenJobVacancy(JobVacancy jobVacancy) {
        
        }
        public bool CloseJobVacancy(int jobId)
        {
            return true;
        }

        public Employee Recruit(JobVacancy jobVacancy, Person person) {
            return new Employee();
        }

        public bool Dismiss(int employeeId, Reason reason) {
            return true;
        }
    }
}
