
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SampleMVVM.Models
{

    public class Student
    {
        public int Id { get; set; }   
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Group { get; set; }
        public int Subgroup { get; set; }
        public int Cours { get; set; }
        public string Subject { get; set; }
        public int Order { get; set; }
        public int Passes { get; set; }
        public Student(string name, string faculty, int group, int subgroup, int cours, string subject, int Order, int Passes)
        {
            this.Name = name;
            this.Faculty = faculty;
            this.Group = group;
            this.Subgroup = subgroup;
            this.Cours = cours;
            this.Subject = subject;
            this.Order = Order;
            this.Passes = Passes;
        }

        public Student() { }
    }
}
