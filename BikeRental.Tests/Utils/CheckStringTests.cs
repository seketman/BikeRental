namespace BikeRental.Tests.Utils
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Utils;

    [TestClass]
    public class CheckStringTests
    {
        /// <summary>
        ///     Check.NotNullOrEmpty tests
        /// </summary>
        [TestMethod]
        public void NotNullOrEmpty_WithValidString_ReturnOriginalValue()
        {
            // Arrange
            string expectedValue = "TestValue";
            string parameterName = "TestParameter";

            // Act
            var returnedValue = Check.NotNullOrEmpty(expectedValue, parameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_WithEmptyString_ThrowArgumentException()
        {
            // Arrange
            string expectedValue = string.Empty;
            string parameterName = "TestParameter";

            // Act
            var returnedValue = Check.NotNullOrEmpty(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_WithSpaceString_ThrowArgumentException()
        {
            // Arrange
            string expectedValue = " ";
            string parameterName = "TestParameter";

            // Act
            var returnedValue = Check.NotNullOrEmpty(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_WithNullString_ThrowArgumentException()
        {
            // Arrange
            string expectedValue = null;
            string parameterName = "TestParameter";

            // Act
            var returnedValue = Check.NotNullOrEmpty(expectedValue, parameterName);

            // Assert is handled by ExpectedException
        }
    }
}
