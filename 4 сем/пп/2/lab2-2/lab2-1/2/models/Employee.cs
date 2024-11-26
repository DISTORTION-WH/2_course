using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.models
{
    public class Employee
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public JobVacancy Vacancy { get; set; }

        public Employee(JobVacancy jobVacancy, Person person)
        {
            Vacancy = jobVacancy;
            Person = person;
        }

        public override string ToString()
        {
            return $"Employee ID: {Id}, Person: {Person}, Job Vacancy: {Vacancy}";
        }
    }
}
