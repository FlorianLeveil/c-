using System.Runtime.CompilerServices;
using System;

namespace WebApplication1.Services
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Elements { get; set; }
        public double PriceUsd { get; set; }
        public double PriceEur { get; set; }
        public Pizza(int id, string name, string elements, int price)
        { 
            Id = id; 
            Name = name;
            Elements = elements;
            PriceUsd = Convert.ToDouble(price);
            addPrices(this);
        }
        private static void addPrices(Pizza my_pizza)
        {
            my_pizza.PriceEur = my_pizza.PriceUsd.ConverToEur();
        }
    }
    
    
}