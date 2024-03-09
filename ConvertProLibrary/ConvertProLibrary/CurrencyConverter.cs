using System.Text.Json;

namespace ConvertProLibrary
{
    public class ExchangeRatesApiResponse
    {
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
    internal class CurrencyConverter
    {
        private const string BaseUrl = "https://api.exchangeratesapi.io/latest";

        public async Task<double> SingleUnitConversion(double amount, string fromCurrency, string toCurrency)
        {
            string url = $"{BaseUrl}?base={fromCurrency}&symbols={toCurrency}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var exchangeRates = JsonSerializer.Deserialize<ExchangeRatesApiResponse>(json);

                    if (exchangeRates.Rates.ContainsKey(toCurrency))
                    {
                        double exchangeRate = exchangeRates.Rates[toCurrency];
                        return amount * exchangeRate;
                    }
                    else
                    {
                        throw new ArgumentException($"Conversion rate not available for {toCurrency}.");
                    }
                }
                else
                {
                    throw new Exception("Failed to fetch exchange rates.");
                }
            }
        }

        public async Task<Dictionary<string, double>> ConvertOneUnitToAll(double amount, string fromCurrency)
        {
            string url = $"{BaseUrl}?base={fromCurrency}";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var exchangeRates = JsonSerializer.Deserialize<ExchangeRatesApiResponse>(json);

                    return exchangeRates.Rates;
                }
                else
                {
                    throw new Exception("Failed to fetch exchange rates.");
                }
            }
        }


    }
}
