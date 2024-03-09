namespace ConvertProLibrary
{
    internal class TimeZoneConverter
    {
        public DateTime SingleUnitConversion(DateTime dateTime, string fromTimeZoneId, string toTimeZoneId)
        {
            try
            {
                TimeZoneInfo fromTimeZone = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZoneId);
                TimeZoneInfo toTimeZone = TimeZoneInfo.FindSystemTimeZoneById(toTimeZoneId);
                return TimeZoneInfo.ConvertTime(dateTime, fromTimeZone, toTimeZone);
            }
            catch (TimeZoneNotFoundException)
            {
                throw new ArgumentException("Invalid timezone ID provided.");
            }
        }

        public Dictionary<string, DateTime> ConvertOneUnitToAll(DateTime dateTime, string fromTimeZoneId)
        {
            TimeZoneInfo[] timeZoneInfos = TimeZoneInfo.GetSystemTimeZones().ToArray();
            Dictionary<string, DateTime> conversionResults = new Dictionary<string, DateTime>();

            foreach (TimeZoneInfo timeZoneIds in timeZoneInfos)
            {
                try
                {
                    DateTime convertedTime = SingleUnitConversion(dateTime, fromTimeZoneId, timeZoneIds.Id);
                    conversionResults.Add(timeZoneIds.Id, convertedTime);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{timeZoneIds.Id}: {ex.Message}");
                }
            }
            return conversionResults;
        }
    }
}

