using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;
        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("currencies")]
        public IEnumerable<string> GetCurrencies()
        {
            return new[] { "USD", "EUR", "GBP", "CNY", "ILS" };
        }

        [HttpGet("exchange-rates/{baseCurrency}")]
        public IEnumerable<object> GetExchangeRates(string baseCurrency)
        {
            // Define exchange rates relative to a base currency
            var exchangeRates = new Dictionary<string, Dictionary<string, double>>()
            {
                { "USD", new Dictionary<string, double> { { "EUR", 0.85 }, { "GBP", 0.75 }, { "CNY", 6.45 }, { "ILS", 3.25 } } },
                { "EUR", new Dictionary<string, double> { { "USD", 1.18 }, { "GBP", 0.88 }, { "CNY", 7.60 }, { "ILS", 3.82 } } },
                { "GBP", new Dictionary<string, double> { { "USD", 1.33 }, { "EUR", 1.14 }, { "CNY", 8.60 }, { "ILS", 4.35 } } },
                { "CNY", new Dictionary<string, double> { { "USD", 0.15 }, { "EUR", 0.13 }, { "GBP", 0.12 }, { "ILS", 0.51 } } },
                { "ILS", new Dictionary<string, double> { { "USD", 0.31 }, { "EUR", 0.26 }, { "GBP", 0.23 }, { "CNY", 1.96 } } },
            };

            // Retrieve the exchange rates for the given base currency
            // if (!exchangeRates.ContainsKey(baseCurrency))
            // {
            //     throw new ArgumentException("Invalid base currency");
            // }

            var currencies = exchangeRates[baseCurrency];

            return currencies.Select(currency => new
            {
                Currency = currency.Key,
                Value = currency.Value
            });
        }

        // public IEnumerable<object> GetExchangeRates(string baseCurrency)
        // {
        //     var currencies = new[] { "USD", "EUR", "GBP", "CNY", "ILS" }.Where(c => c != baseCurrency);
        //     var random = new Random();
        //     return currencies.Select(currency => new
        //     {
        //         Currency = currency,
        //         Value = Math.Round(random.NextDouble() * (1.5 - 0.5) + 0.5, 2)
        //     });
        // }
    }
}


    