using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            var restaurant = new Restaurants();
            Console.WriteLine($"My close friend {FirstName} {LastName} is meeting me at {restaurant.RestaurantNames}");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} is eating a {food} at the office today.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurants();
            Console.WriteLine($"{FirstName} is going to meet me at {restaurant.RestaurantNames} along with .");
            foreach (var person in companions)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurants();
            Console.WriteLine($"{FirstName} ate {food} at {restaurant.RestaurantNames} along with ");
            foreach (var person in companions)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}
