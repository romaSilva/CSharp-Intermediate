using System;

namespace NumberGuessing
{
    class Program
    {

        public static bool CheckResults(int prizeNumber, int guessedNumber)
        {
            if (guessedNumber == prizeNumber)
            {
                Console.WriteLine("Parabéns, você acertou!");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Que pena, você errou");
                Console.WriteLine();
                return false;
            }
        }

        static void Main()
        {

            var rnd = new Random();
            int randomNum = rnd.Next(1, 10);
            bool gotIt;

            while (true)
            {
                Console.Write($"({randomNum})");

                Console.Write("Tente advinhar o número: ");
                Int32.TryParse(Console.ReadLine(), out int result);

                if (result == 0)
                {
                    Console.WriteLine("Digite um número!");
                    Console.WriteLine();
                    continue;
                }
                else
                {

                    gotIt = CheckResults(randomNum, result);
                }

                if (gotIt)
                {
                    Console.WriteLine("Deseja jogar novamente? S ou N: ");
                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        randomNum = rnd.Next(1, 10);
                        continue;
                    }
                    else break;
                }
            }
        }
    }
}
