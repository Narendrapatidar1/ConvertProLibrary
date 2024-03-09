namespace ConvertProLibrary
{
    public class ConvertPro : IConvertPro
    {
        public double ConvertLengthToUnit(double value, string fromUnit, string toUnit)
        {
            LengthConverter lc = new LengthConverter();
            return lc.SingleUnitConversion(value, fromUnit, toUnit);
        }

        public Dictionary<string, double> ConvertLengthToAll(double value, string fromUnit)
        {
            LengthConverter lc = new LengthConverter();
            return lc.ConvertOneUnitToAll(value, fromUnit);
        }
        public double ConvertWeightToUnit(double value, string fromUnit, string toUnit)
        {
            WeightConverter wc = new WeightConverter();
            return wc.SingleUnitConversion(value, fromUnit, toUnit);
        }

        public Dictionary<string, double> ConvertWeightToAll(double value, string fromUnit)
        {
            WeightConverter wc = new WeightConverter();
            return wc.ConvertOneUnitToAll(value, fromUnit);
        }
        public double ConvertTimeToUnit(double value, string fromUnit, string toUnit)
        {
            TimeConverter tc = new TimeConverter();
            return tc.SingleUnitConversion(value, fromUnit, toUnit);
        }

        public Dictionary<string, double> ConvertTimeToAll(double value, string fromUnit)
        {
            TimeConverter tc = new TimeConverter();
            return tc.ConvertOneUnitToAll(value, fromUnit);
        }
        public DateTime ConvertTimeZoneToUnit(DateTime value, string fromUnit, string toUnit)
        {
            TimeZoneConverter tzc = new TimeZoneConverter();
            return tzc.SingleUnitConversion(value, fromUnit, toUnit);
        }

        public Dictionary<string, DateTime> ConvertTimeZoneToAll(DateTime value, string fromUnit)
        {
            TimeZoneConverter tzc = new TimeZoneConverter();
            return tzc.ConvertOneUnitToAll(value, fromUnit);
        }

        public double ConvertCurrencyToUnit(double value, string fromUnit, string toUnit)
        {
            CurrencyConverter cr = new CurrencyConverter();
            return cr.SingleUnitConversion(value, fromUnit, toUnit).Result;
        }

        public Dictionary<string, double> ConvertCurrencyToAll(double value, string fromUnit)
        {
            CurrencyConverter cr = new CurrencyConverter();
            return cr.ConvertOneUnitToAll(value, fromUnit).Result;
        }
        public double ConvertDataStorageToUnit(double value, string fromUnit, string toUnit)
        {
            DataStorageConverter dsc = new DataStorageConverter();
            return dsc.SingleUnitConversion(value, fromUnit, toUnit);
        }

        public Dictionary<string, double> ConvertDataStorageToAll(double value, string fromUnit)
        {
            DataStorageConverter dsc = new DataStorageConverter();
            return dsc.ConvertOneUnitToAll(value, fromUnit);
        }
    }
}