namespace BikeRental.Model
{
    /// <summary>
    ///     Promotion interface
    /// </summary>
    public interface IPromotion
    {
        string Name { get; }

        int BikesCount { get; }

        decimal DiscountFactor { get; }
    }
}
