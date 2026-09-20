using System.ComponentModel.Design;

namespace NumberGameLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int number = random.Next(1, 20);
            int guesser = 0;
            bool correctNumber = false;
            



            Console.WriteLine("Gissa ett nummer mellan 1 och 20, du får 5 försök.");

            for (int attempts = 0; attempts < 5; attempts++)
            {

                if (int.TryParse(Console.ReadLine(), out guesser))
                {
                    correctNumber = CheckGuess(guesser, number);


                    if (correctNumber)
                    {
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Du får inte skriva i bokstäver, skriv ett heltal istället");
                    attempts--;
                }
            }

            if (!correctNumber)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }



            static bool CheckGuess(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine("För högt nummer, gissa igen");
                    return false;
                }
                else if (a < b)
                {
                    Console.WriteLine("För lågt nummer, gissa igen");
                    return false;
                }
                else
                {
                    Console.WriteLine($"Wohoo! Du klarade det!");
                    return true;
                }
            }




        }
    }
}