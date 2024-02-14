namespace CreatingAClassFileAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colonist chat = new Colonist();
            Colonist greyLeno = new Colonist("Grey Leno");
            
            chat.Status();
            Console.WriteLine(chat.FavoriteColor());
            Console.ReadLine();
            
            Console.WriteLine(greyLeno.FavoriteColor("Black"));
            Console.ReadLine();
            
            

            greyLeno.Damage(2);
            Console.WriteLine(greyLeno.Status());
            Console.ReadLine();
            
            greyLeno.Damage(2);
            Console.WriteLine(greyLeno.Status());
            Console.ReadLine();
            
            greyLeno.Damage(2);
            Console.WriteLine(greyLeno.Status());
            Console.ReadLine();
            
            greyLeno.Damage(2);
            Console.WriteLine(greyLeno.Status());
            Console.ReadLine();
            
            greyLeno.Damage(2);
            Console.WriteLine(greyLeno.Status());
            Console.ReadLine();
        }
    }
}
