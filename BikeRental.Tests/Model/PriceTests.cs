namespace BikeRental.Tests.Model
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Model;

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
    }
}
