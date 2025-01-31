using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5, 7, 3, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var total = new UnitTestMethods();

            //Act
            var actual = total.AddMethod(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var remainder = new UnitTestMethods();
            //Act
            var actual = remainder.Subtraction(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var total = new UnitTestMethods();
            //Act
            var actual = total.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var div = new UnitTestMethods();
            //Act
            var actual = div.Divided(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var hello = new UnitTestMethods();
            //Act
            var actual = hello.GetHello();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var kitty = new UnitTestMethods();
            //Act
            var actual = kitty.MyCat();
            //Assert
            Assert.Equal("Manchu", actual);
        }
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        [InlineData(10, 3628800)]

        public void GetFactorial(int x, int expected)
        {
            //Arrange
            var fact = new UnitTestMethods();
            //Act
            var actual = fact.Factorial(x);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Passw0rd", true)]
        [InlineData("password", false)]
        [InlineData("MonkeyB0ne", true)]
        [InlineData("MonkeyBone", false)]
        [InlineData("", false)]
        [InlineData("        ", false)]
        [InlineData("12345678", false)]
        
        public void Password(string tester, bool expected)
        {
            //Arrange
            var pass = new UnitTestMethods();
            //Act
            var actual = pass.PassWord(tester);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
