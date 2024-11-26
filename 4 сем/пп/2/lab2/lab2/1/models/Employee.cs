using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
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
            return $"Айди работожателя: {Id}, Имя: {Person}, Название вакансии: {Vacancy}";
        }
    }
}
