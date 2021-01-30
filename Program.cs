using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy("Spike", "Lee");
            lunchBuddy.eat();
            lunchBuddy.eat("pizza");
            lunchBuddy.eat(new List<LunchBuddy>
            {
                new LunchBuddy("Deddrick", "Perry"),
                new LunchBuddy("Carla", "Patton"),
                new LunchBuddy("Pierre", "Keys")
            });

            lunchBuddy.eat("nachos", new List<LunchBuddy>
            {
                new LunchBuddy("Pamela", "Patton"),
                new LunchBuddy("Imani", "Ross"),
                new LunchBuddy("Logan", "Ross")
            });
        }
    }
}
