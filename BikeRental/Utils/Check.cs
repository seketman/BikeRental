namespace BikeRental.Utils
{
    using System;

    /// <summary>
    ///     Class for check parameters
    /// </summary>
    public class Check
    {
        public const string ArgumentIsNullOrEmpty = "Argument is null or empty";
        public const string NegativeValuesAreNotAllowedMessage = "Negative values are not allowed";
        public const string NegativeOrZeroValuesAreNotAllowedMessage = "Negative or zero values are not allowed";

        /// <summary>
        ///     Verify that a string is not null or empty.
        /// </summary>
        /// <param name="value">Parameter value to verify</param>
        /// <param name="parameterName">Parameter name</param>
        /// <returns>Verified string value</returns>
        public static string NotNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ArgumentIsNullOrEmpty, parameterName);
            }

            return value;
        }

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

        /// <summary>
        ///     Verify that the decimal value is not zero or negative. 
        /// </summary>
        /// <param name="value">Parameter value to verify</param>
        /// <param name="parameterName">Parameter name</param>
        /// <returns>Verified decimal value</returns>
        public static decimal NotZeroOrNegative(decimal value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, NegativeOrZeroValuesAreNotAllowedMessage);
            }

            return value;
        }

        /// <summary>
        ///     Verify that the integer value is not negative. 
        /// </summary>
        /// <param name="value">Parameter value to verify</param>
        /// <param name="parameterName">Parameter name</param>
        /// <returns>Verified integer value</returns>
        public static int NotNegative(int value, string parameterName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, NegativeValuesAreNotAllowedMessage);
            }

            return value;
        }

        /// <summary>
        ///     Verify that the integer value is not zero or negative. 
        /// </summary>
        /// <param name="value">Parameter value to verify</param>
        /// <param name="parameterName">Parameter name</param>
        /// <returns>Verified integer value</returns>
        public static int NotZeroOrNegative(int value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName, value, NegativeOrZeroValuesAreNotAllowedMessage);
            }

            return value;
        }
    }
}
