namespace CreatingAClassFileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster mrBones = new Monster(10);
            mrBones.Sekeleton();
            mrBones.health--;
            Console.WriteLine("The skeleton's health has been reduced to " + mrBones.health);
            Monster slime = new Monster(15);
            Console.WriteLine(slime.SlimeChamp(5) + " colonists are in need of treatment.");
        }
    }
}
