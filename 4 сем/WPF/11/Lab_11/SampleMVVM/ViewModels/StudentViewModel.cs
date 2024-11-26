using SampleMVVM.Commands;
using SampleMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SampleMVVM.ViewModels
{
    //предоставить данные модели (Model) Student в удобной для представления (View) форме
    class StudentViewModel : ViewModelBase 
     {
        

        public Student Student;

        public StudentViewModel(Student student)
        {
            
            this.Student = student;
        }

        public string Name
        {
            get { return Student.Name; }
            set
            {
                Student.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Faculty
        {
            get { return Student.Faculty; }
            set
            {
                Student.Faculty = value;
                OnPropertyChanged("Faculty");
            }
        }

        public int Group
        {
            get { return Student.Group; }
            set
            {
                Student.Group = value;
                OnPropertyChanged("Group");
            }
        }

        public int Subgroup
        {
            get { return Student.Subgroup; }
            set
            {
                Student.Subgroup = value;
                OnPropertyChanged("Subgroup");
            }
        }

        public int Cours
        {
            get { return Student.Cours; }
            set
            {
                Student.Cours = value;
                OnPropertyChanged("Cours");
            }
        }

        public string Subject
        {
            get { return Student.Subject; }
            set
            {
                Student.Subject = value;
                OnPropertyChanged("Subject");
            }
        }

        public int Order
        {
            get { return Student.Order; }
            set
            {
               if (value > 10) { Student.Order = 10; }
                else if (value < 1) { Student.Order = 1; }

                else 
                {
                    
                try
                {
                    Student.Order = value;
                }
                catch
                {
                    return;
                }

                }

                OnPropertyChanged("Order");
            }
        }

        public int Passes
        {
            get { return Student.Passes; }
            set
            {
                Student.Passes = value;

                if (value > 72) { Student.Passes = 72; }
                else if (value < 0) { Student.Passes = 0; }

                else
                {

                    try
                    {
                        Student.Passes = value;
                        
                        
                    }
                    catch
                    {
                        return;
                    }


                }

                OnPropertyChanged("Passes");
            }
        }

    }
}
