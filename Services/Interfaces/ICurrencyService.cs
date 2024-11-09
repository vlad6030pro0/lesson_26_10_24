using System;

namespace lesson_26_10_24.Services.Interfaces;

public interface ICurrencyService
{
    Task<decimal> GetExchangeRateAsync(string currencyCode); // Например RUB
}
