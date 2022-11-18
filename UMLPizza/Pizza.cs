using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPizza
{
    public class Pizza
    {

        public int PizzaNO { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public string Ingredients {get; set; }
        public Pizza(int pizzano, string pizzaname, double price, string ingredients)
        {
            PizzaNO = pizzano;
            PizzaName = pizzaname;
            Price = price;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"Number {PizzaNO}, {PizzaName}, {Price} kr \n\t{Ingredients}";
        }

    }
}
