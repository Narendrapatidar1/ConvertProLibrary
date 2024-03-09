namespace ConvertProLibrary
{
    internal class WeightConverter
    {
        public double SingleUnitConversion(double value, string fromUnit, string toUnit)
        {
            Dictionary<string, double> conversionFactors = new Dictionary<string, double>()
            {
                {"mg", 0.001},
                {"g", 1.0},
                {"kg", 1000.0},
                {"ton", 1000000.0},
                {"lb", 453.592},
                {"oz", 28.3495}
            };

            if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
            {
                double valueInGrams = value * conversionFactors[fromUnit];
                double result = valueInGrams / conversionFactors[toUnit];
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid unit(s) provided.");
            }
        }

        public Dictionary<string, double> ConvertOneUnitToAll(double value, string fromUnit)
        {
            string[] weightUnits = { "mg", "g", "kg", "ton", "lb", "oz" };
            Dictionary<string, double> conversionResults = new Dictionary<string, double>();

            foreach (string toUnit in weightUnits)
            {
                double result = SingleUnitConversion(value, fromUnit, toUnit);
                conversionResults.Add(toUnit, result);
            }

            return conversionResults;
        }
    }
}
