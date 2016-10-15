namespace BikeRental.Model
{
    /// <summary>
    ///     Price for a time unit of rental
    /// </summary>
    public class Price : IPrice
    {
        public Price(Time.UnitsEnum timeUnit, decimal amount)
        {
            this.TimeUnit = timeUnit;
            this.Amount = amount;
        }

        public Time.UnitsEnum TimeUnit { get; private set; }
        public decimal Amount { get; private set; }
    }
}
