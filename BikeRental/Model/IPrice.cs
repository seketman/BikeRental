namespace BikeRental.Model
{
    /// <summary>
    ///     Price interface
    /// </summary>
    public interface IPrice
    {
        Time.UnitsEnum TimeUnit { get; }

        decimal Amount { get; }
    }
}
