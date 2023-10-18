namespace ChallangeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void StringTest_ReturnShouldBeCorrect()
        {
            //arrange
            string firstName1 = "Arek";
            string firstName2 = "Arek";

            //act

            //assert
            Assert.AreEqual(firstName1, firstName2);

        }

        [Test]
        public void IntTest_ReturnShouldBeCorrect()
        {
            //arrange
            int number1 = 15;
            int number2 = 17;

            //act


            //assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void FloatTest_ReturnShouldBeCorrect()
        {
            //arrange
            float value1 = 2.1f;
            float value2 = 2.1f;

            //act

            //assert
            Assert.AreEqual(value1, value2);

        }

        [Test]
        public void ReferenceStringTest_ReturnShouldBeCorrect()
        {
            //arrange
            var employee4 = GetEmployee("Arek");
            var employee5 = GetEmployee("Arek");

            //act

            //assert
            Assert.AreNotEqual(employee4, employee5);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}