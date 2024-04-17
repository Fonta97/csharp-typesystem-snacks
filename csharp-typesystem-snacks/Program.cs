namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
