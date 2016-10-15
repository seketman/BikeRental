namespace BikeRental.Model
{
    using Utils;

    /// <summary>
    ///     Promotion for a specific number of bykes rental
    /// </summary>
    public class Promotion : IPromotion
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Promotion"/> class.
        /// </summary>
        /// <param name="name">Promotion name</param>
        /// <param name="bikesCount">Minimun number of bikes rental for apply</param>
        /// <param name="discountFactor">Multiply factor to discount</param>
        public Promotion(string name, int bikesCount, decimal discountFactor)
        {
            this.Name = Check.NotNullOrEmpty(name, "name");
            this.BikesCount = Check.NotZeroOrNegative(bikesCount, "bikesCount");
            this.DiscountFactor = Check.NotZeroOrNegative(discountFactor, "discountFactor");
        }

        public string Name { get; private set; }

        public int BikesCount { get; private set; }

        public decimal DiscountFactor { get; private set; }
    }
}
