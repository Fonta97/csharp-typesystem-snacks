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
            Console.WriteLine("Dammi due parole e te le metterò in ordine di lunghezza decrescente! ;P");
            Console.WriteLine("Parola 1: ");
            string parola1 = Console.ReadLine();
            Console.WriteLine("Parola 2: ");
            string parola2 =  Console.ReadLine();
            if (parola1.Length < parola2.Length)
            {
                Console.WriteLine($"Ecco le parole in ordine di lunghezza decrescente è {parola2}, {parola1}");
            } else
            {
                Console.WriteLine($"Ecco le parole in ordine di lunghezza decrescente è {parola1}, {parola2}");
            }

            Console.WriteLine("Snack 3");
            Console.WriteLine("Farò la somma di tutti i 10 numeri che mi darai! SONO FORTISSIMO!");

            //creazione variabile somma
            decimal somma = 0;

           for (int i = 0; i < 10; i++)
            {
            Console.WriteLine("Dammi un numero: ");
            decimal numero = decimal.Parse(Console.ReadLine());

                somma += numero;

            }
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {somma}");


            //Calcola la somma e la media dei numeri da 2 a 10.
            Console.WriteLine("Snack 4");
            int sommaRange = 0;

            for (int i = 2; i < 11; i++)
            {
                sommaRange += i;
            }
            Console.WriteLine($"Eccoti la somma e la media dei numeri da 2 a 10: {sommaRange}");



        }
    }
}
