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
            var currencies = new[] { "USD", "EUR", "GBP", "CNY", "ILS" }.Where(c => c != baseCurrency);
            var random = new Random();
            return currencies.Select(currency => new
            {
                Currency = currency,
                Value = Math.Round(random.NextDouble() * (1.5 - 0.5) + 0.5, 2)
            });
        }
    }
}