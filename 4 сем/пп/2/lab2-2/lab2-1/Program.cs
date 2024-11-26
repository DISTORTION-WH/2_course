// See https://aka.ms/new-console-template for more information

using lab2._1.classes;
using lab2._1.models;

public class Program
{
    static void Main()
    {
        University university = new University("Belstu", "BSTU", "Pushkina Dom Kalatushkina");
        Faculty faculty = new Faculty("Information Technologies", "IT", "Pushkina Dom Kalatushkina");
        faculty.AddDepartment(new Department("Some department"));

        university.AddFaculty(faculty);

        university.PrintInfo();
    }
}