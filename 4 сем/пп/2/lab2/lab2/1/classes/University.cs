using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    public class University
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }

        protected List<Faculty> faculties = new List<Faculty>();

        public University() { 
        
        }

        public University(University university)
        {
            faculties = university.faculties;
        }

        public University(string name, string shortName, string address)
        {
            Name = name;
            ShortName = shortName;
            Address = address;
        }

        public int AddFaculty(Faculty faculty)
        {
            faculty.Id = GenerateUniqueId(faculties);

            faculties.Add(faculty);
            return faculty.Id;
        }

        public bool delFaculty (int id)
        {
            Faculty FacultyToRemove = faculties.FirstOrDefault(d => d.Id == id);
            if (FacultyToRemove != null)
            {
                return faculties.Remove(FacultyToRemove);
            }
            return false;
        }

        public bool UpdFaculty(Faculty faculty)
        {
            int index = faculties.FindIndex(f => f.Id == faculty.Id);
            if (index != -1)
            {
                faculties[index] = faculty;
                return true;
            }
            return false;
        }

        private bool verFaculty(int id)
        {
            return faculties.Any(f => f.Id == id);
        }

        public List<Faculty> getFaculties() { return faculties; }

        public void PrintInfo()
        {
            foreach (Faculty faculty  in faculties)
            {
                Console.WriteLine(faculty);
            }
        }

        public List<JobVacancy> GetJobVacancies()
        {
            List<JobVacancy> vacancies = new List<JobVacancy>();

            foreach (Faculty item in faculties)
            {
                foreach (JobVacancy vacancy in item.GetJobVacancies())
                {
                    vacancies.Add(vacancy);
                }
            }

            return vacancies;
        }

        public int AddJobTitle(JobTitle jobTitle)
        {
            int facultyId = jobTitle.Id;

            return faculties[facultyId].AddJobTitle(jobTitle);
        }

        public bool DelJobTitle(int id)
        {
            return faculties[id].DelJobTitle(id);
        }

        public int OpenJobVacansy(JobVacancy jobVacancy)
        {
            int facultyId = jobVacancy.Id;

            return faculties[facultyId].OpenJobVacancy(jobVacancy);
        }

        public bool CloseJobVacansy(int id)
        {
            return faculties[id].CloseJobVacancy(id);
        }

        public Employee Recruit(JobVacancy jobVacancy, Person person)
        {
            int facultyId = jobVacancy.Id;

            return faculties[facultyId].Recruit(jobVacancy, person);
        }

        public void Dismiss(int id, Reason reason)
        {
            faculties[id].Dismiss(id, reason);
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
    }
}
