using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClassFileAssignment
{
    internal class Colonist
    {
        public string name = "New Colonist";
        private int health = 10;
        private string mood = "Happy";
        private string favoriteColor = "Sage";

        public Colonist()
        {

        }
        public Colonist(string initialName)
        {
            name = initialName;
        }

        public string FavoriteColor()
        {
            return favoriteColor;
        }

        public string FavoriteColor(string newColor)
        {
            favoriteColor = newColor;
            return favoriteColor;
        }

        public void Damage(int damageAmount)
        {
            health -= damageAmount;
            Console.WriteLine(name + " was damaged by " + damageAmount + " points. Health is now " + health);

            UpdateMood();
        }

        private void UpdateMood()
        {
            if(health > 7) mood = "Happy";
            else if(health > 4) mood = "Neutral";
            else if(health > 0) mood = "Upset";
            else mood = "Dead";
        }

        public string Status()
        {
            switch(mood)
            {
                case "Happy":
                    Console.WriteLine(name + " is doing pretty well!");
                    break;
                case "Neutral":
                    Console.WriteLine(name + " is fine. Nothing to note here.");
                    break;
                case "Upset":
                    Console.WriteLine(name + " isn't too happy with things right now.");
                    break;
                case "Dead":
                    Console.WriteLine(name + " is pretty frustrated at the moment, in part because they have died recently.");
                    break;
            }
            return mood;
        }
    }
}
