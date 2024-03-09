namespace ConvertProLibrary
{
    internal class LengthConverter
    {
        public double SingleUnitConversion(double value, string fromUnit, string toUnit)
        {
            Dictionary<string, double> conversionFactors = new Dictionary<string, double>()
            {
                {"mm", 0.001},
                {"cm", 0.01},
                {"m", 1.0},
                {"km", 1000.0},
                {"inch", 0.0254},
                {"ft", 0.3048},
                {"yd", 0.9144},
                {"mile", 1609.34}
            };

            if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
            {
                double valueInMeters = value * conversionFactors[fromUnit];

                double result = valueInMeters / conversionFactors[toUnit];
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid unit(s) provided.");
            }
        }

        public Dictionary<string, double> ConvertOneUnitToAll(double value, string fromUnit)
        {
            string[] lengthUnits = { "mm", "cm", "m", "km", "inch", "ft", "yd", "mile" };

            Dictionary<string, double> conversionResults = new Dictionary<string, double>();

            foreach (string toUnit in lengthUnits)
            {
                double result = SingleUnitConversion(value, fromUnit, toUnit);
                conversionResults.Add(toUnit, result);
            }
            return conversionResults;
        }

    }
}
