namespace BikeRental.Model
{
    using Utils;

    /// <summary>
    ///     Price for a time unit of rental
    /// </summary>
    public class Price : IPrice
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Price"/> class.
        /// </summary>
        /// <param name="timeUnit">Time unit of the price</param>
        /// <param name="amount">Amount of the price</param>
        public Price(Time.UnitsEnum timeUnit, decimal amount)
        {
            this.TimeUnit = timeUnit;
            this.Amount = Check.NotNegative(amount, "amount");
        }

        public Time.UnitsEnum TimeUnit { get; private set; }

        public decimal Amount { get; private set; }
    }
}
