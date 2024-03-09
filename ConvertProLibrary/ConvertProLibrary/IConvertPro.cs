namespace ConvertProLibrary
{
    internal interface IConvertPro
    {
        double ConvertLengthToUnit(double value, string fromUnit, string toUnit);

        Dictionary<string, double> ConvertLengthToAll(double value, string fromUnit);

        double ConvertWeightToUnit(double value, string fromUnit, string toUnit);

        Dictionary<string, double> ConvertWeightToAll(double value, string fromUnit);

        double ConvertTimeToUnit(double value, string fromUnit, string toUnit);

        Dictionary<string, double> ConvertTimeToAll(double value, string fromUnit);

        DateTime ConvertTimeZoneToUnit(DateTime value, string fromUnit, string toUnit);

        Dictionary<string, DateTime> ConvertTimeZoneToAll(DateTime value, string fromUnit);

        double ConvertCurrencyToUnit(double value, string fromUnit, string toUnit);

        Dictionary<string, double> ConvertCurrencyToAll(double value, string fromUnit);

        double ConvertDataStorageToUnit(double value, string fromUnit, string toUnit);

        Dictionary<string, double> ConvertDataStorageToAll(double value, string fromUnit);
    }
}
