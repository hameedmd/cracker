using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace cracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first character");
            var firstCharacter = Console.ReadLine();

            Console.WriteLine("Please enter your second character");
            var secondCharacter = Console.ReadLine();

            Console.WriteLine("Please enter your third character");
            var thirdCharacter = Console.ReadLine();

            Console.WriteLine("Please enter your fourth character");
            var fourthCharacter = Console.ReadLine();

            Console.WriteLine("Please enter your fifth character");
            var fifthCharacter = Console.ReadLine();

            if (fifthCharacter == "na")
            {
                var alphabet = firstCharacter + secondCharacter + thirdCharacter + fourthCharacter ;
                var q = alphabet.Select(x => x.ToString());
                int size = 4;
                for (int i = 0; i < size - 1; i++)
                    q = q.SelectMany(x => alphabet, (x, y) => x + y);

                foreach (var item in q)
                    Console.WriteLine(item);
            }
            else
            {
                var alphabet = firstCharacter + secondCharacter + thirdCharacter + fourthCharacter + fifthCharacter;
                var q = alphabet.Select(x => x.ToString());
                int size = 5;
                for (int i = 0; i < size - 1; i++)
                    q = q.SelectMany(x => alphabet, (x, y) => x + y);

                foreach (var item in q)
                    Console.WriteLine(item);


            }
        }
    }
}

