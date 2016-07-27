using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arrange - SETUP
            int input = 1;

            //Act - WORD NEED TO DO
            string ouput = FizzBuzzer.GETValue(input);

            //Assert
            Assert.AreEqual("1", ouput);
        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4,7,8,11,13,14)] int input)
        {
            string ouput = FizzBuzzer.GETValue(input);
            Assert.AreEqual(input.ToString(), ouput);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3,6,9,12)]int input)
        {
            string output = FizzBuzzer.GETValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz([Values(5,10)]int input)
        {
            string output = FizzBuzzer.GETValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void BuzzerWhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15)] int input)
        {
            string output = FizzBuzzer.GETValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }

    }
}
