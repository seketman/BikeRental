namespace BikeRental.Utils
{
    using System;

    /// <summary>
    ///     Class for check parameters
    /// </summary>
    public class Check
    {
        public const string NegativeValuesAreNotAllowedMessage = "Negative values are not allowed";

        /// <summary>
        ///     Verify that the decimal value is not negative. 
        /// </summary>
        /// <param name="value">Parameter value to verify</param>
        /// <param name="parameterName">Parameter name</param>
        /// <returns>Verified decimal value</returns>
        public static decimal NotNegative(decimal value, string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, NegativeValuesAreNotAllowedMessage);
            }

            return value;
        }
    }
}
