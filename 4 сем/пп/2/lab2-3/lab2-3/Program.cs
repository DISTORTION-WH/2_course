// See https://aka.ms/new-console-template for more information

using lab2._1.classes;
using lab2._1.models;

public class Program
{
    static void Main()
    {
        University university = new University("Belstu", "BSTU", "Pushkina Dom Kalatushkina");
        Faculty faculty = new Faculty("Information Technologies", "IT", "Pushkina Dom Kalatushkina");

        university.AddFaculty(faculty);

        university.Recruit(
            new JobVacancy(
                new JobTitle("Teacher MatCat", 1), "Teacher"),
                new Person("Andrey", "Kasach")
        );

        university.PrintInfo();
    }
}