using static ChallangeApp.EmployeeBase;

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        int Age { get; }

        char Gender { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);


        event GradeAddedDalegate GradeAdded;

        Statistics GetStatistics();
    }
}
