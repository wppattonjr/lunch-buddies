using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurants
    {
        public string RestaurantNames;
        List<string> restaurants = new List<string> { "SouthernV", "Sunflower Cafe", "Slim and Husky", "Taco Bell" };

        public Restaurants()
        {
            Random randomRestaurant = new Random();
            int index = randomRestaurant.Next(restaurants.Count);
            RestaurantNames = restaurants[index];
        }
    }
}
