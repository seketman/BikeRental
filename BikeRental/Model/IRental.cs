namespace BikeRental.Model
{
    using System;

    /// <summary>
    ///     Rental interface
    /// </summary>
    public interface IRental
    {
        int BikesCount { get; }

        DateTime StartingAt { get; }

        Time.UnitsEnum TimeUnit { get; }

        int TimeValue { get; }

        decimal TotalCost { get; }

        decimal TotalDiscount { get; }

        decimal NetAmount { get; }
    }
}
