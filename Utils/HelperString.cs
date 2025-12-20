namespace JMeterReportExport.Utils
{
    using System.Globalization;

    public static class HelperString
    {
        public static double ParsePercentage(string value)
        {
            // Handle null or empty strings
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            // Remove the '%' character and trim any whitespace
            string cleanedValue = value.Replace("%", "").Trim();

            // Parse the cleaned string to a double
            if (double.TryParse(
                cleanedValue, 
                NumberStyles.Any, 
                CultureInfo.InvariantCulture, 
                out double result
            )) {
                return result / 100;
            }

            // Return 0 if parsing fails
            return 0;
        }
    }
}
