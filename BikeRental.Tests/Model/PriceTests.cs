namespace BikeRental.Tests.Model
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Model;
    using System;

    [TestClass]
    public class PriceTests
    {
        [TestMethod]
        public void Price_WithPositiveAmount_Created()
        {
            // Arrange
            decimal expectedAmount = 10;

            // Act
            var price = new Price(Time.UnitsEnum.Hour, expectedAmount);

            // Assert
            Assert.AreEqual(expectedAmount, price.Amount);
        }

        [TestMethod]
        public void Price_WithZeroAmount_Created()
        {
            // Arrange
            decimal expectedAmount = 0;

            // Act
            var price = new Price(Time.UnitsEnum.Hour, expectedAmount);

            // Assert
            Assert.AreEqual(expectedAmount, price.Amount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Price_WithNegativeAmount_ThrownArgumentOutOfRangeException()
        {
            // Arrange
            decimal expectedAmount = -10;

            // Act
            var price = new Price(Time.UnitsEnum.Hour, expectedAmount);

            // Assert is handled by ExpectedException
        }
    }
}
