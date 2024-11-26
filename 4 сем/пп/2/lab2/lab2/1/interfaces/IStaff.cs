using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.interfaces
{
    public interface IStaff
    {
        List<JobVacancy> GetJobVacancies();
        List<Employee> GetEmployees();
        List<JobTitle> GetJobTitles();
        int AddJobTitle(JobTitle jobTitle);
        string PrintJobVacancies();
        bool DelJobTitle(int jobTitleId);
        void OpenJobVacancy(JobVacancy jobVacancy);
        bool CloseJobVacancy(int jobId);
        Employee Recruit(JobVacancy jobVacancy, Person person);
        bool Dismiss(int employeeId, Reason reason);
    }
}
