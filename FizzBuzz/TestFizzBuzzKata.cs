using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [TestFixture]
    public class TestFizzBuzzKata
    {
        [TestCase(1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]
        [TestCase(6, "fizz")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(9, "fizz")]
        [TestCase(10, "buzz")]
        [TestCase(11, "11")]
        [TestCase(12, "fizz")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        [TestCase(15, "fizzbuzz")]
        public void FizzBuzzKata_Answer(int number, string expected)
        {
            // Arrange
            var fizzBuzzKata = new FizzBuzzKata();

            // Act
            var actual = fizzBuzzKata.Answer(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
