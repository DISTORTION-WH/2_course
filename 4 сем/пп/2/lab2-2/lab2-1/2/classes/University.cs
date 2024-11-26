using lab2._1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.classes
{
    public class University: Organization
    {
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
    }
}
