namespace ConvertProLibrary
{
    internal class TimeConverter
    {
        public double SingleUnitConversion(double value, string fromUnit, string toUnit)
        {
            Dictionary<string, double> conversionFactors = new Dictionary<string, double>()
        {
            {"second", 1.0},
            {"minute", 60.0},
            {"hour", 3600.0},
            {"day", 86400.0},
            {"week", 604800.0},
            {"month", 2629800.0},
            {"year", 31557600.0}
        };

            if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
            {
                double valueInSeconds = value * conversionFactors[fromUnit];
                double result = valueInSeconds / conversionFactors[toUnit];
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid unit(s) provided.");
            }
        }

        public Dictionary<string, double> ConvertOneUnitToAll(double value, string fromUnit)
        {
            string[] timeUnits = { "second", "minute", "hour", "day", "week", "month", "year" };
            Dictionary<string, double> conversionResults = new Dictionary<string, double>();

            foreach (string toUnit in timeUnits)
            {
                double result = SingleUnitConversion(value, fromUnit, toUnit);
                conversionResults.Add(toUnit, result);
            }
            return conversionResults;
        }
    }
}
