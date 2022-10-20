using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace HTTP5112_Assignment2_MichelleParlevliet.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Takes user order input and returns statement with number of calories in the menu selections
        /// </summary>
        /// <param name="Burger"></param>
        /// <param name="Drink"></param>
        /// <param name="Side"></param>
        /// <param name="Dessert"></param>
        /// <returns>
        /// "Your total calorie count is x"
        /// </returns>
        /// <example>
        /// GET: localhost/api/J1/menu/4/4/4/4 -> "Your total calorie count is 0"
        /// </example>
        
        [HttpGet]
        [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]

        public IEnumerable<string> Menu(int Burger, int Drink, int Side, int Dessert)
        {
            int CheeseBurger = 461;
            int FishBurger = 431;
            int VeggieBurger = 420;

            int Softdrink = 130;
            int OrangeJuice = 160;
            int Milk = 118;

            int Fries = 100;
            int BakedPotato = 57;
            int ChefSalad = 70;

            int ApplePie = 167;
            int Sundae = 266;
            int FruitCup = 75;

            int NoOrder = 0;

            /// BURGER LOGIC
            if (Burger == 1)
            {
                Burger = CheeseBurger;
            }
            else if (Burger == 2)
            {
                Burger = FishBurger;
            }
            else if (Burger == 3)
            {
                Burger = VeggieBurger;
            }
            else if (Burger == 4) 
            {
                Burger = NoOrder;
            }

            /// DRINK LOGIC
            if (Drink == 1)
            {
                Drink = Softdrink;
            }
            else if (Drink == 2)
            {
                Drink = OrangeJuice;
            }
            else if (Drink == 3)
            {
                Drink = Milk;
            }
            else if (Drink == 4)
            {
               Drink = NoOrder;
            }

            /// SIDE LOGIC
            if (Side == 1)
            {
               Side = Fries;
            }
            else if (Side == 2)
            {
               Side = BakedPotato;
            }
            else if (Side == 3)
            {
               Side = ChefSalad;
            }
            else if (Side == 4)
            {
               Side = NoOrder;
            }

            /// DESSERT LOGIC
            if (Dessert == 1)
            {
               Dessert = ApplePie;
            }
            else if (Dessert == 2)
            {
                 Dessert = Sundae;
            }
            else if (Dessert == 3)
            {
               Dessert = FruitCup;
            }
            else if (Dessert == 4)
            {
               Dessert = NoOrder;
            }

            /// RETURN STATEMENT
            int TotalCalories = Burger + Drink + Side + Dessert;
            return new string[]
            {
               "Your total calorie count is " + TotalCalories
            };
        }
    }
}
