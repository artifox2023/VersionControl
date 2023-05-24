using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotCakes2;
using NUnit.Framework;

namespace UnitTestKliens
{
    public class KliensTest
    {

        [
            Test,
            TestCase("", false),
            TestCase("qwe", true),
            TestCase("2000", true)

        ]
        public void TestNotEmpty(string textboxValue, bool expectedResult)
        {
            // Arrange
            var form = new Form1();

            // Act
            var actualResult = form.ValidateTextboxNotEmpty(textboxValue);


            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [
            Test,
            TestCase("", false),
            TestCase("qwe", false),
            TestCase("Alma12", false),
            TestCase("2450.6", false),
            TestCase("123", true)
        ]
        public void TestPriceIsInt(string price, bool expectedResult)
        {
            // Arrange
            var form = new Form1();

            // Act
            var actualResult = form.ValidatePriceCanConvInt(price);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
