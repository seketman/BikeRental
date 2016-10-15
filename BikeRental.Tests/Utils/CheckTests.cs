namespace BikeRental.Tests.Utils
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Utils;
    using System;

    [TestClass]
    public class CheckTests
    {
        [TestMethod]
        public void CheckNotNegative_WithPositiveValue_ReturnOriginalValue()
        {
            // Arrange
            decimal expectedValue = 10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void CheckNotNegative_WithZero_ReturnOriginalValue()
        {
            // Arrange
            decimal expectedValue = 0;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckNotNegative_WithNegativeValue_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            decimal expectedValue = -10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }
    }
}