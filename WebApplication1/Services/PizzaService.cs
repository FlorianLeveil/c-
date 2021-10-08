using System;
using System.Collections.Generic;
using System.Linq;
using pizza.Domain;

namespace WebApplication1.Services
{
    public class PizzaService
    {
        
        public static List<Pizza> GetAll()
        {
            return PizzaRepository.GetPizzas();
        }
        
        public static IEnumerable<Pizza> GetOnePizza(int ?_id)
        {
            IEnumerable<Pizza> query = GetAll()
                .Where(n => n.Id.Equals(_id))
                .Select(n => n);
            return query;
        }        
        public static IEnumerable<Pizza> GetOnePizzaOrAll(int ?_id)
        {
            if (String.IsNullOrEmpty(_id.ToString()))
            {
                try 
                {
                    return GetAll();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                if (_id < 0)
                {
                    throw new ArgumentException("Negative ID !");
                }
                try
                {
                    return GetOnePizza(_id);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
        }
    }
}

// - Handling Exception
// - PizzaController (HttpStatusCode) Error: 500 / NotFound: 404
// - PizzaService (TryCatch)
// - PriceService (ConvertToUSD + TryCatch)