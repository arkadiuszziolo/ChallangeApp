namespace ChallangeApp
{
    public class Employee
    {
        List<int> points = new List<int>();
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public int Result { 
            get
            {
                return points.Sum();
            } 
        }

        public void AddScore(int number)
        {
            this.points.Add(number);
        }
    }
}
