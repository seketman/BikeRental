namespace BikeRental.Tests.Model
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BikeRental.Model;
    using System;

    [TestClass]
    public class PromotionTests
    {
        [TestMethod]
        public void Promotion_WithValidParameters_Created()
        {
            // Arrange
            string expectedName = "Test";
            int bikesCount = 1;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert
            Assert.AreEqual(expectedName, promotion.Name);
        }

        /// <summary>
        ///     Test promotion name parameter variations
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Promotion_WithEmptyStringName_ThrowArgumentException()
        {
            // Arrange
            string expectedName = string.Empty;
            int bikesCount = 1;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Promotion_WithSpaceStringName_ThrowArgumentException()
        {
            // Arrange
            string expectedName = " ";
            int bikesCount = 1;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Promotion_WithNullStringName_ThrowArgumentException()
        {
            // Arrange
            string expectedName = null;
            int bikesCount = 1;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        /// <summary>
        ///     Test promotion bikes count parameter variations
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Promotion_WithZeroBikesCount_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            string expectedName = "Test";
            int bikesCount = 0;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Promotion_WithNegativeBikesCount_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            string expectedName = "Test";
            int bikesCount = -1;
            decimal discountFactor = 0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        /// <summary>
        ///     Test promotion discount factor parameter variations
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Promotion_WithZeroDiscountFactor_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            string expectedName = "Test";
            int bikesCount = 1;
            decimal discountFactor = 0m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Promotion_WithNegativeDiscountFactor_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            string expectedName = "Test";
            int bikesCount = 1;
            decimal discountFactor = -0.1m;

            // Act
            var promotion = new Promotion(expectedName, bikesCount, discountFactor);

            // Assert is handled by ExpectedException
        }
    }
}
