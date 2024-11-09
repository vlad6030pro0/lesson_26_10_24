using System;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace lesson_26_10_24.Services.Interfaces;

public class CurrencyService : ICurrencyService
{
    private readonly HttpClient httpClient;
    private readonly string apiKey = "219e4373ea4c03d32829d2c9";
    
    public CurrencyService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<decimal> GetExchangeRateAsync(string currencyCode)
    {
        var request = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";
        var response = await httpClient.GetStringAsync(request);
        var json = JObject.Parse(response);
        var rate = json?["conversion_rates"]?[currencyCode];

        if(rate != null)
        {
            return rate.Value<decimal>();
        }
        
        return 0.0m;
    }
}
