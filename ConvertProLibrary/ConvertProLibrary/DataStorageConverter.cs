namespace ConvertProLibrary
{
    internal class DataStorageConverter
    {
        private const double BytesInKilobyte = 1024;
        private const double BytesInMegabyte = 1024 * BytesInKilobyte;
        private const double BytesInGigabyte = 1024 * BytesInMegabyte;
        private const double BytesInTerabyte = 1024 * BytesInGigabyte;

        public double SingleUnitConversion(double value, string fromUnit, string toUnit)
        {
            Dictionary<string, double> conversionFactors = new Dictionary<string, double>()
            {
                {"byte", 1.0},
                {"kilobyte", BytesInKilobyte},
                {"megabyte", BytesInMegabyte},
                {"gigabyte", BytesInGigabyte},
                {"terabyte", BytesInTerabyte}
            };

            if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
            {
                double valueInBytes = value * conversionFactors[fromUnit];
                double result = valueInBytes / conversionFactors[toUnit];
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid unit(s) provided.");
            }
        }

        public Dictionary<string, double> ConvertOneUnitToAll(double value, string fromUnit)
        {
            string[] dataStorageUnits = { "byte", "kilobyte", "megabyte", "gigabyte", "terabyte" };
            Dictionary<string, double> conversionResults = new Dictionary<string, double>();

            foreach (string toUnit in dataStorageUnits)
            {
                double result = SingleUnitConversion(value, fromUnit, toUnit);
                conversionResults.Add(toUnit, result);
            }

            return conversionResults;
        }
    }
}

