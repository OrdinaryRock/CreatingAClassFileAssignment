using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClassFileAssignment
{
    internal class Monster
    {
        public int health = 0;
        public Monster(int initialHealth)
        {
            health = initialHealth;
        }

        public void Sekeleton()
        {
            Console.WriteLine("The skeleton is not happy to see you today.");
            Console.WriteLine("You attack the skeleton.");
            Console.WriteLine("This worsens his mood.");
        }

        public int SlimeChamp(int num)
        {
            Console.WriteLine("SlimeChamp gave birth to " + num + " skibidis.");
            Console.WriteLine((num / 2) + " are ready for the mines.");
            Console.WriteLine("Chat is pleased.");
            return num / 2;
        }
    }
}
