using ProjetoRPG.Entities;


namespace ProjetoRPG
{

    class Program 
    {

        static void Main(string[] args)
        {
           
            Knight aragorn = new Knight("Aragorn", 23, "Knight", 100, 50);
            Wizard gandalf = new Wizard("Gandalf", 23, "Wizard", 100, 60);
            Hunter legolas = new Hunter("Legolas", 25, "Hunter", 100, 60);
            Hobbit frodo = new Hobbit("Frodo", 40, "Hobbit", 100, 20);

            Console.WriteLine(aragorn.ToString());
            Console.WriteLine(gandalf.ToString());
            Console.WriteLine(legolas.ToString());
            Console.WriteLine(frodo.ToString());

            Console.WriteLine();

            Console.WriteLine(aragorn.Attack());
            Console.WriteLine(gandalf.Defense());
            Console.WriteLine(legolas.Attack(8));
            Console.WriteLine(frodo.Defense());







        }
    }

}