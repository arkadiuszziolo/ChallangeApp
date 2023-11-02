namespace ChallangeApp.Tests
{
    public class EmployeeTest
    {
        [Test]
        public void AverageFloat_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade(15.1F);
            employee.AddGrade(5.5F);
            employee.AddGrade(21.1F);
            employee.AddGrade(7.1F);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(12.20F,2), Math.Round(statistics.Average),2);

        }

        [Test]
        public void Average_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(21);
            employee.AddGrade(7);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.LessOrEqual(12, statistics.Average);

        }

        [Test]
        public void Min_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(21);
            employee.AddGrade(7);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Min);

        }

        [Test]
        public void Max_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade(15);
            employee.AddGrade(5);
            employee.AddGrade(21);
            employee.AddGrade(7);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(21, statistics.Max);
        }

        [Test]
        public void CharAverageTest_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('c');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(80, statistics.Average);
        }


        [Test]
        public void CharMinTest_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistics.Min);
        }

        [Test]
        public void CharMaxTest_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void CharAverageLetter_TestCorrect()
        {
            //arrange
            var employee = new Employee("Arek", "Zioło");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}