using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Library.Tests
{
    [TestFixture]
    public class MyMethodTests
    {
        [Test]
        public void MyMethod_When_String_ReturnReverse()
        {
            //Arrange 
            string input = "Good";
            string expected = "doog";

            //Act
            string actual = MyMethods.ReverseWord(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseWord_When_StringEmpty_Returns_Empty()
        {
            string input = string.Empty;

            //Act
            string output = MyMethods.ReverseWord(input);

            //Assert
            Assert.AreEqual("empty", output);
        }

        [Test]
        public void TestFactorial()
        {
            //arrange
            int input = 5;
            int expected = 120;

            //act
            int output = MyMethods.Factorial(input);

            //assert
            Assert.AreEqual(expected, output);

        }

        [Test]
        public void TestFactorialWhenInput2_Returns2()
        {
            //arrange
            int input = 2;
            int expected = 2;

            //act
            int output = MyMethods.Factorial(input);

            //assert
            Assert.AreEqual(expected, output);

        }

        [Test]
        public void TestFactorialWhenInput1_Returns1()
        {
            //arrange
            int input = 1;
            int expected = 1;

            //act
            int output = MyMethods.Factorial(input);

            //assert
            Assert.AreEqual(expected, output);

        }

        [Test]
        public void TestFactorialLoop_Input5_Returns5()
        {
            //arrange
            int input = 5;
            int expected = 120;

            //act
            int output = MyMethods.FactorialLoop(input);

            //assert
            Assert.AreEqual(expected, output);

        }

        [Test]
        public void testFibbonaci()
        {
            //Arrange - setup
            int input = 5;

            //Act - work need to be done
            int output = MyMethods.Fib(input);

            //Assert
            Assert.AreEqual(5, output);
        }

        [Test]
        public void testRecFib_When5_Returns120()
        {
            //arrange - setup
            int input = 5;
            int expected = 5;

            //act - work need to be done

       
            int output = MyMethods.FibRecurssion(input);


            //assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestMax()
        {
            int[] a = { 2, 4, 10, 5, 6 };
            int expected = 10;

            int max = MyMethods.GetMax(a);

            Assert.AreEqual(expected, max);
        }

        [Test]
        public void pennyShading()
        {
            //Arrange - setup
            double input = 1.000134;

            double  expected = 34;
            //Act - work need to be done

            double output = MyMethods.PennyShade(input);
            
            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}
