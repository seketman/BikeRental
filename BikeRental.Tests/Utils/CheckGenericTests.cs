using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeRental.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Utils.Tests
{
    [TestClass()]
    public class CheckGenericTests
    {
        [TestMethod()]
        public void NotNullObject_WithObject_ReturnsOriginalObject()
        {
            // Arrange
            object expectedValue = new object();
            var expectedParameterName = "Test";

            // Act
            var returnedValue = Check.NotNull(expectedValue, expectedParameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullObject_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            object expectedValue = null;
            var expectedParameterName = "Test";

            // Act
            var returnedValue = Check.NotNull(expectedValue, expectedParameterName);

            // Assert is handled by ExpectedException
        }

        [TestMethod()]
        public void NotNullValue_WithValue_ReturnsOriginalValue()
        {
            // Arrange
            int? expectedValue = 1;
            var expectedParameterName = "Test";

            // Act
            var returnedValue = Check.NotNull(expectedValue, expectedParameterName);

            // Assert
            Assert.AreEqual(expectedValue, returnedValue);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullvalue_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            int? expectedValue = null;
            var expectedParameterName = "Test";

            // Act
            var returnedValue = Check.NotNull(expectedValue, expectedParameterName);

            // Assert is handled by ExpectedException
        }
    }
}