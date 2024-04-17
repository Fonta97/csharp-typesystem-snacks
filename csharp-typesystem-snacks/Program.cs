﻿using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine("Snack 5");
            Console.WriteLine("Dammi un numero e se è pari te lo ristampo, altrimenti ti stamperò il numero pari successivo!");
            int PaliODispali = int.Parse(Console.ReadLine());
            if (PaliODispali % 2 == 0)
            {
                Console.WriteLine($"Si, il numero {PaliODispali} è pari!");
            } else
            {
                Console.WriteLine($"No, il numero {PaliODispali} non è pari, eccoti il numero pari successivo ad esso: {PaliODispali+1}" );
            }

            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            Console.WriteLine("Snack 6");

            string[] invitati = { "Gatsby", "Paolo", "Anna", "Rey Misteryo"};
            bool presente = false;
            Console.WriteLine($"Benvenuto alla festa del grande Gatsby! Dammi il tuo nome e ti dirò se sei sulla lista!");
            string nomeTuo = Console.ReadLine();
            foreach (string invitato in invitati)
            {
                if (invitato == nomeTuo) {
                    presente = true;
                }
            }
            if (presente==true)
            {
                Console.WriteLine("Entra pure broski!");
            } else
            {
                Console.WriteLine("Ti mando via a calci imbucato!");
            }

            // Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            Console.WriteLine("Snack 7");
        }
    }
}
