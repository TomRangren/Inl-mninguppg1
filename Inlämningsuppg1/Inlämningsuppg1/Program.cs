using System;

namespace Inlämningsuppg1
{
    class Program
    {
        static void Main()
        {
            Random generator = new Random();
            int Slump = generator.Next(1, 100), Antalgissningar = 0;
            Console.WriteLine("Gissa ett tal mellan 1-100!: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            while(tal != Slump)
            {
                if (tal < Slump)
                {
                    Console.WriteLine("Du gissar för lågt!Gissa högre");
                        }
                else if (tal > Slump)
                {
                    Console.WriteLine("Du gissar för högt!Gissa lägre");
                }
                    tal = Convert.ToInt32(Console.ReadLine());
                    Antalgissningar++;
                }
                    Console.WriteLine("Du gissade rätt!");
                    Console.WriteLine("Du gissade " + Antalgissningar + " gånger");
                    Console.ReadLine();

        }
    }
}
