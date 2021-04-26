using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int AddMethod(int x, int y, int z)
        {
            return x+y+z;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtraction(int min, int sub)
        {
            return min-sub;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int a, int b)
        {
            return a*b;
        }

        // Create a Divide method that passes 2 integers
        public int Divided (int a, int b)

        {
            return a/b;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string GetHello()
        {
            return "Hello";
        }
        public string MyCat()
        {
            return "Manchu";
        }

        
    }
}
