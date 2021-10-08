using System;
using System.Collections.Generic;
using System.Linq;
using pizza.Domain;

namespace WebApplication1.Services
{
    public static class PriceService
    {
        public static double ConverToEur(this double usd)
        {
            if (usd >= 100)
            {
                throw new ArgumentException("La Pizza n'est pas au bon prix: " + usd);
            }            
            if (usd < 0) 
            {
                throw new ArgumentException("La Pizza à un prix negatif: " + usd);
            }
            if (usd > 0)
            {
                return usd * 0.85;
            }
            return usd;
        }
    }
}

// - Handling Exception
//
//     - PizzaController (HttpStatusCode) Error: 500 / NotFound: 404
//     - PizzaService (TryCatch)
//     - PriceService (ConvertToUSD + TryCatch)