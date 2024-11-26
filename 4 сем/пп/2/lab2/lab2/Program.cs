
using lab2_1;
using lab2;

public class Program
{
    static void Main()
    {
        University university = new University("бел. гос технолог университет", "бгту", "свердлова 26");
        Faculty faculty = new Faculty("информационные технологии", "айти", "свердлова 26");

        university.AddFaculty(faculty);
        university.OpenJobVacansy(new JobVacancy(new JobTitle("преподаватель по англу", 1), "преподаватель"));

        university.Recruit(
            new JobVacancy(
                new JobTitle("преподаватель по англу", 1), "преподаватель"),
                new Person("Глеб", "Шатерник")
        );

        university.PrintInfo();
    }
}