﻿namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDalegate(object sender, EventArgs args);

        public abstract event GradeAddedDalegate GradeAdded;

        public EmployeeBase(string name, string surname, int age, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name {  get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public char Gender { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);


        public abstract void AddGrade(long grade);


        public abstract void AddGrade(int grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();

    }
}
