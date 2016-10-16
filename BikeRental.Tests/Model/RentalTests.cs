namespace BikeRental.Tests.Model
{
    using System;
    using System.Collections.Generic;
    using BikeRental.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    /// <summary>
    ///     Rental class tests
    /// </summary>
    [TestClass]
    public class RentalTests
    {
        #region Common arrange
        private List<IPrice> prices = new List<IPrice>
            {
                new Price(Time.UnitsEnum.Hour, 5),
                new Price(Time.UnitsEnum.Day, 20),
                new Price(Time.UnitsEnum.Week, 60)
            };

        private List<IPromotion> promotions = new List<IPromotion>
            {
                new Promotion("Family Rental", 3, 0.30m),
                new Promotion("Family Rental", 4, 0.30m),
                new Promotion("Family Rental", 5, 0.30m)
            };
        #endregion Common arrange

        [TestMethod]
        public void Rental_WithOneBikeOneHourAndNoPromotion_Created()
        {
            // Arrange
            int expectedBikesCount = 1;
            var expectedTimeUnit = Time.UnitsEnum.Hour;
            var expectedTimeValue = 1;

            var expectedTotalCost = 5m;
            var expectedTotalDiscount = 0m;
            var expectedNetAmount = 5m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithThreeBikesAndFamilyPromotion_Created()
        {
            // Arrange
            int expectedBikesCount = 3;
            var expectedTimeUnit = Time.UnitsEnum.Hour;
            var expectedTimeValue = 1;

            var expectedTotalCost = 15m;
            var expectedTotalDiscount = 4.5m;
            var expectedNetAmount = 10.5m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithThreeBikesAndNoPromotions_Created()
        {
            // Arrange
            int expectedBikesCount = 3;
            var expectedTimeUnit = Time.UnitsEnum.Hour;
            var expectedTimeValue = 1;

            var expectedTotalCost = 15m;
            var expectedTotalDiscount = 0m;
            var expectedNetAmount = 15m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, null);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithFiveBikesAndFamilyPromotion_Created()
        {
            // Arrange
            int expectedBikesCount = 5;
            var expectedTimeUnit = Time.UnitsEnum.Day;
            var expectedTimeValue = 2;

            var expectedTotalCost = 200m;
            var expectedTotalDiscount = 60m;
            var expectedNetAmount = 140m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithFiveBikesAndNoPromotions_Created()
        {
            // Arrange
            int expectedBikesCount = 5;
            var expectedTimeUnit = Time.UnitsEnum.Day;
            var expectedTimeValue = 2;

            var expectedTotalCost = 200m;
            var expectedTotalDiscount = 0m;
            var expectedNetAmount = 200m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, null);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithTenBikesAndFamilyPromotion_Created()
        {
            // Arrange
            int expectedBikesCount = 10;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = 3;

            var expectedTotalCost = 1800m;
            var expectedTotalDiscount = 540m;
            var expectedNetAmount = 1260m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        public void Rental_WithTenBikesAndNoPromotions_Created()
        {
            // Arrange
            int expectedBikesCount = 10;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = 3;

            var expectedTotalCost = 1800m;
            var expectedTotalDiscount = 0m;
            var expectedNetAmount = 1800m;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, null);

            // Assert
            Assert.AreEqual(expectedBikesCount, rental.BikesCount);
            Assert.AreEqual(expectedTimeUnit, rental.TimeUnit);
            Assert.AreEqual(expectedTimeValue, rental.TimeValue);

            Assert.AreEqual(expectedTotalCost, rental.TotalCost);
            Assert.AreEqual(expectedTotalDiscount, rental.TotalDiscount);
            Assert.AreEqual(expectedNetAmount, rental.NetAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rental_WithZeroBikeCount_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedBikesCount = 0;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = 3;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rental_WithNegativeBikeCount_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedBikesCount = -3;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = 3;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rental_WithZeroTimeValue_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedBikesCount = 1;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = 0;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Rental_WithNegativeTimeValue_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int expectedBikesCount = 1;
            var expectedTimeUnit = Time.UnitsEnum.Week;
            var expectedTimeValue = -3;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, this.prices, this.promotions);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Rental_WithoutTimeUnitPrice_ThrowArgumentException()
        {
            // Arrange
            var prices = new List<IPrice>
            {
                new Price(Time.UnitsEnum.Hour, 5),
                //new Price(Time.UnitsEnum.Day, 20),
                new Price(Time.UnitsEnum.Week, 60)
            };

            int expectedBikesCount = 1;
            var expectedTimeUnit = Time.UnitsEnum.Day;
            var expectedTimeValue = 3;

            // Act
            var rental = new Rental(expectedBikesCount, expectedTimeUnit, expectedTimeValue, prices, this.promotions);

            // Assert is handled by ExpectedException
        }
    }
}
