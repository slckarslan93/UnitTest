using UnitTest.APP;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            ////Arrange
            //int a = 5;
            //int b = 20;
            //var calculator = new Calculator();
            ////Act
            //var total = calculator.add(a, b);

            ////Assert
            //Assert.Equal<int>(25, total);

            //Assert.Contains("Selçuk", "Selçuk Arslan");

            //Assert.DoesNotContain("Ali", "Selçuk Arslan");

            //var names = new List<string>() { "Ali", "Veli", "Ayşe" };

            //Assert.Contains(names, x => x == "Ali");

            //Assert.True(5 > 2);

            var regEx = "^dog";

            Assert.Matches(regEx, "dog flufy");
        }
    }
}