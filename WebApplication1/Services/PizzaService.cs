using System;
using System.Collections.Generic;
using System.Linq;
using pizza.Domain;

namespace WebApplication1.Services
{
    public static class PizzaService
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
                return GetAll();
            }
            else
            {
                return GetOnePizza(_id);
            }
        }
        
        public static double ConverToEur(this double usd)
        {
            if (usd > 0)
            {
                return usd * 0.85;
            }
            return usd;
        }
    }
}