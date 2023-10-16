namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoSetOfPoints_ResultShouldBeCorrect()
        {
            //arrange
            var employee = new Employee("Maciek","asdaf", 18);
            employee.AddScore(10);
            employee.AddScore(15);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(25, result);
        }
        [Test]
        public void WhenEmployeeCollectMinusPoints_ResultShouldBeCorrect()
        {
            //arrange
            var employee = new Employee("Maciek","asdaf", 18);
            employee.AddScore(-10);
            employee.AddScore(-15);
            employee.AddScore(-15);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-40, result);
        }
        [Test]
        public void WhenEmployeeCollectPlusAndMinusPoints_ResultShouldBeCorrect()
        {
            //arrange
            var employee = new Employee("Maciek","asdaf", 18);
            employee.AddScore(-10);
            employee.AddScore(-15);
            employee.AddScore(-15);
            employee.AddScore(10);
            employee.AddScore(2);
            employee.AddScore(0);
            employee.AddScore(12);
            employee.AddScore(1);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-15, result);
        }
    }
} 