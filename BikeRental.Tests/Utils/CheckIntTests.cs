namespace BikeRental.Tests.Utils
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Utils;

    [TestClass]
    public class CheckIntTests
    {
        /// <summary>
        ///     CheckNotNegative tests
        /// </summary>
        [TestMethod]
        public void NotNegative_WithPositiveValue_ReturnOriginalValue()
        {
            // Arrange
            int expectedValue = 10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        public void NotNegative_WithZero_ReturnOriginalValue()
        {
            // Arrange
            int expectedValue = 0;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotNegative_WithNegativeValue_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedValue = -10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotNegative(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }

        /// <summary>
        ///     CheckNotNegative tests
        /// </summary>
        [TestMethod]
        public void NotZeroOrNegative_WithPositiveValue_ReturnOriginalValue()
        {
            // Arrange
            int expectedValue = 10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotZeroOrNegative(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotZeroOrNegative_WithZero_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedValue = 0;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotZeroOrNegative(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotZeroOrNegative_WithNegativeValue_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedValue = -10;
            string parameterName = "Test";

            // Act
            var returnedValue = Check.NotZeroOrNegative(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }
    }
}
