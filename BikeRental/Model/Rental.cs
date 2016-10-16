namespace BikeRental.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utils;

    /// <summary>
    ///     Rental of a specific number of bikes
    /// </summary>
    public class Rental
    {
        public const string NoPriceDefinedMessage = "No price defined for '{0}' time unit";

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rental"/> class.
        /// </summary>
        /// <param name="bikesCount">Number of bikes to rent</param>
        /// <param name="startingAt">Starting date and time</param>
        /// <param name="timeUnit">Time unit</param>
        /// <param name="timeValue">Time value</param>
        /// <param name="prices">List of prices</param>
        /// <param name="promotions">List of promotions</param>
        public Rental(int bikesCount, DateTime startingAt, Time.UnitsEnum timeUnit, int timeValue, IList<IPrice> prices, IList<IPromotion> promotions)
        {
            Check.NotNull(prices, "prices");

            this.BikesCount = Check.NotZeroOrNegative(bikesCount, "bikesCount");
            this.StartingAt = startingAt;

            this.TimeUnit = timeUnit;
            this.TimeValue = Check.NotZeroOrNegative(timeValue, "timeValue");

            this.TotalCost = this.CalculateTotalCost(bikesCount, timeUnit, timeValue, prices);
            this.TotalDiscount = this.CalculateTotalDiscount(this.TotalCost, bikesCount, promotions);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Rental"/> class with default startingAt date.
        /// </summary>
        /// <param name="bikesCount">Number of bikes to rent</param>
        /// <param name="timeUnit">Time unit</param>
        /// <param name="timeValue">Time value</param>
        /// <param name="prices">List of prices</param>
        /// <param name="promotions">List of promotions</param>
        public Rental(int bikesCount, Time.UnitsEnum timeUnit, int timeValue, IList<IPrice> prices, IList<IPromotion> promotions)
            : this(bikesCount, DateTime.UtcNow, timeUnit, timeValue, prices, promotions)
        {
        }

        public int BikesCount { get; private set; }

        public DateTime StartingAt { get; private set; }

        public Time.UnitsEnum TimeUnit { get; private set; }

        public int TimeValue { get; private set; }

        #region Amounts of rental
        public decimal TotalCost { get; private set; }

        public decimal TotalDiscount { get; private set; }

        public decimal NetAmount
        {
            get
            {
                return this.TotalCost - this.TotalDiscount;
            }
        }
        #endregion Amounts of rental

        #region Private methods
        /// <summary>
        ///     Calculate the total cost of the rent
        /// </summary>
        /// <param name="bikesCount">Number of bikes to rent</param>
        /// <param name="timeUnit">Time unit of the rent</param>
        /// <param name="timeValue">Time value</param>
        /// <param name="prices">List of prices</param>
        /// <returns>Total cost of the rent</returns>
        private decimal CalculateTotalCost(int bikesCount, Time.UnitsEnum timeUnit, int timeValue, IList<IPrice> prices)
        {
            // Take de price for the timeUnit received
            var price = prices.FirstOrDefault(p => p.TimeUnit.Equals(timeUnit));
            if (price == null)
            {
                var errorMessage = string.Format(NoPriceDefinedMessage, timeUnit);
                throw new ArgumentException(errorMessage, "price");
            }

            return bikesCount * timeValue * price.Amount;
        }

        /// <summary>
        ///     Apply promotions if any for this rent
        /// </summary>
        /// <param name="totalCost">Total amount of the rent</param>
        /// <param name="bikesCount">Number of bikes to rent</param>
        /// <param name="promotions">List of promotions</param>
        /// <returns>Total discount amount after apply promotions</returns>
        private decimal CalculateTotalDiscount(decimal totalCost, int bikesCount, IList<IPromotion> promotions)
        {
            if (promotions == null)
            {
                return 0m;
            }

            // Take the first promotion with the highest discountFactor value
            var promotion = promotions
                .Where(p => p.BikesCount <= bikesCount)
                .OrderByDescending(p => p.DiscountFactor)
                .FirstOrDefault();

            if (promotion == null)
            {
                return 0m;
            }

            return totalCost * promotion.DiscountFactor;
        }
        #endregion Private methods
    }
}
