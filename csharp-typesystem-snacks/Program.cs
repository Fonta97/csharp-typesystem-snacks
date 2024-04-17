namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snack 1");
            Console.WriteLine("Dammi due numeri e ti dirò il maggiore!");
            Console.WriteLine("Numero 1: ");
            decimal number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            decimal number2 = decimal.Parse(Console.ReadLine());
            if (number1 < number2)
            {
                Console.WriteLine($"Il numero maggiore è {number2}");
            } else
            {
                Console.WriteLine($"Il numero maggiore è {number1}");
            }

            Console.WriteLine("Snack 2");
            Console.WriteLine("Dammi due parole e ti dirò la più lunga! ;P");
            Console.WriteLine("Parola 1: ");
            string parola1 = Console.ReadLine();
            Console.WriteLine("Parola 2: ");
            string parola2 =  Console.ReadLine();
            if (parola1.Length < parola2.Length)
            {
                Console.WriteLine($"La parola più lunga è {parola2}");
            } else
            {
                Console.WriteLine($"La parola più lunga è {parola1}");
            }


            
        }
    }
}
