using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public class Author
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Author()
        {
            // Пустой конструктор без параметров
        }
        public Author(string name, string surname, string patronymic, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
        }
    }
}
